using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class FormPengembalian : Form
    {
        public FormPengembalian()
        {
            InitializeComponent();
            dataListAlat.DataSource = null;
            dataListAlat.DataSource = new ControllerPeminjam().getJadwal();
        }

        private void labelNomorHp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (dataListAlat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih peminjaman yang akan dikembalikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxKondisi.Text))
            {
                MessageBox.Show("Isi kondisi alat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataListAlat.SelectedRows[0];
            Peminjaman peminjaman = (Peminjaman)row.DataBoundItem;

            using (var db = new TugasAkhirPboContext())
            {
                var peminjamanCek = db.Peminjamen
                    .Include(p => p.Pengembalian)
                    .FirstOrDefault(p => p.IdPeminjaman == peminjaman.IdPeminjaman);

                if (peminjamanCek?.Pengembalian != null)
                {
                    MessageBox.Show("Peminjaman ini sudah pernah dikembalikan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string kondisiAlat = string.IsNullOrWhiteSpace(textBoxKondisi.Text) ? "Tidak diketahui" : textBoxKondisi.Text.Trim();
            DateOnly tanggalPengembalian = DateOnly.FromDateTime(dateTimePicker1.Value.Date);
            string hariKembali = peminjaman.TanggalKembali ?? "";
            int dendaNominal = 0;

            if (DateOnly.TryParse(hariKembali, out DateOnly tanggalJatuhTempo) && tanggalPengembalian > tanggalJatuhTempo)
            {
                int selisihHari = tanggalPengembalian.DayNumber - tanggalJatuhTempo.DayNumber;
                dendaNominal = selisihHari * 5000;
            }

            string denda = dendaNominal > 0 ? $"Rp. {dendaNominal:N0}" : "Tanpa Denda";

            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin mengajukan pengembalian?\n\nDenda: {denda}",
                "Konfirmasi Pengembalian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string idPengembalian = "PG" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    new Pengembalian().inputPengembalian(idPengembalian, peminjaman.IdPeminjaman, tanggalPengembalian, kondisiAlat, denda);

                    MessageBox.Show("Pengembalian berhasil diajukan! Menunggu konfirmasi admin.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengajukan pengembalian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
