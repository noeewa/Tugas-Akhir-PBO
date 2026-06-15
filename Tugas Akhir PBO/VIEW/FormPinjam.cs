using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class FormPinjam : Form
    {
        List<Alat> list_alat = new List<Alat>();

        public FormPinjam()
        {
            InitializeComponent();
            AlatGridBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AlatListBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AlatGridBox.DataSource = new ControllerPeminjam().getAlatByStatus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Batal
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tambah
            if (AlatGridBox.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu!");
                return;
            }

            foreach (DataGridViewRow row in AlatGridBox.SelectedRows)
            {
                Alat alat = (Alat)row.DataBoundItem;

                if (!list_alat.Contains(alat))
                {
                    list_alat.Add(alat);
                }
            }

            AlatListBox.DataSource = null;
            AlatListBox.DataSource = list_alat;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Ajukan
            if (list_alat.Count == 0)
            {
                MessageBox.Show("Silakan tambahkan alat yang ingin dipinjam terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateStartPick.Value.Date > DateEndPick.Value.Date)
            {
                MessageBox.Show("Tanggal kembali tidak boleh sebelum tanggal mulai pinjam!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin mengajukan peminjaman untuk {list_alat.Count} alat?",
                "Konfirmasi Peminjaman",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new TugasAkhirPboContext())
                    {
                        var allPmjs = db.Peminjamen.Select(p => p.IdPeminjaman).ToList();
                        List<int> pmjNumbers = new List<int>();
                        foreach (var id in allPmjs)
                        {
                            if (id != null && id.StartsWith("PMJ-") && int.TryParse(id.Substring(4), out int num))
                            {
                                pmjNumbers.Add(num);
                            }
                        }
                        pmjNumbers.Sort();
                        int nextPmjNum = 0;
                        foreach (int n in pmjNumbers)
                        {
                            if (n != nextPmjNum) break;
                            nextPmjNum++;
                        }
                        string newIdPeminjaman = "PMJ-" + nextPmjNum.ToString("D3");
                        string detail = string.Join(", ", list_alat.Select(a => a.NamaAlat));
                        Peminjaman peminjaman = new Peminjaman()
                        {
                            IdPeminjaman = newIdPeminjaman,
                            IdUser = UserSession.UserId,
                            DetailPeminjaman = detail,
                            TanggalPeminjaman = DateStartPick.Value.ToString("yyyy-MM-dd"),
                            TanggalKembali = DateEndPick.Value.ToString("yyyy-MM-dd")
                        };
                        db.Peminjamen.Add(peminjaman);
                        var allJdws = db.Jadwals.Select(j => j.IdJadwal).ToList();
                        List<int> jdwNumbers = new List<int>();
                        foreach (var id in allJdws)
                        {
                            if (id != null && id.StartsWith("JDW-") && int.TryParse(id.Substring(4), out int num))
                            {
                                jdwNumbers.Add(num);
                            }
                        }
                        jdwNumbers.Sort();
                        int nextJdwNum = 0;
                        foreach (int n in jdwNumbers)
                        {
                            if (n != nextJdwNum) break;
                            nextJdwNum++;
                        }

                        foreach (var selectedAlat in list_alat)
                        {
                            string newIdJadwal = "JDW-" + nextJdwNum.ToString("D3");
                            nextJdwNum++;

                            Jadwal jadwal = new Jadwal()
                            {
                                IdJadwal = newIdJadwal,
                                IdAlat = selectedAlat.IdAlat,
                                TanggalMulai = DateOnly.FromDateTime(DateStartPick.Value),
                                TanggalSelesai = DateOnly.FromDateTime(DateEndPick.Value),
                                IdPeminjaman = newIdPeminjaman
                            };
                            db.Jadwals.Add(jadwal);
                            var alatToUpdate = db.Alats.Find(selectedAlat.IdAlat);
                            if (alatToUpdate != null)
                            {
                                alatToUpdate.Status = true;
                            }
                        }

                        db.SaveChanges();
                    }

                    MessageBox.Show("Pengajuan peminjaman berhasil diajukan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AlatListBox.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih alat yang ingin dihapus dari daftar pinjam terlebih dahulu!");
                return;
            }

            foreach (DataGridViewRow row in AlatListBox.SelectedRows)
            {
                Alat alat = (Alat)row.DataBoundItem;
                if (alat != null)
                {
                    list_alat.Remove(alat);
                }
            }

            AlatListBox.DataSource = null;
            AlatListBox.DataSource = list_alat;
        }
    }
}
