using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DsbProsesPengembalian : Form
    {
        public DsbProsesPengembalian()
        {
            InitializeComponent();
            ListPengembalian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadPengembalian();
        }

        public void loadPengembalian()
        {
            ListPengembalian.DataSource = new Pengembalian().GetAllPengembalianWithPeminjaman();
            ListAlatBox.DataSource = new Alat().GetAlatByStatus();
        }

        private void bKonfirmasi_Click(object sender, EventArgs e)
        {
            if (ListPengembalian.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih pengembalian yang akan dikonfirmasi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = ListPengembalian.SelectedRows[0];
            Pengembalian pengembalian = (Pengembalian)row.DataBoundItem;

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin mengkonfirmasi pengembalian ini dan membuat riwayat?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string idRiwayat = "RW" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string idUser = pengembalian.IdPeminjamanNavigation?.IdUser ?? "";
                    string idPeminjaman = pengembalian.IdPeminjaman ?? "";

                    new Riwayat().inputRiwayat(idRiwayat, idUser, pengembalian.IdPengembalian, idPeminjaman);

                    MessageBox.Show("Pengembalian berhasil dikonfirmasi dan riwayat telah dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPengembalian();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengkonfirmasi pengembalian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}