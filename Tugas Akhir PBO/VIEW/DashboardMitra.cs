using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.CONTROLLER;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DashboardMitra : Form
    {
        public DashboardMitra()
        {
            try
            {
                InitializeComponent();
                if (string.IsNullOrEmpty(UserSession.UserId))
                {
                    this.Close();
                    return;
                }
                dataGridAlat.DataSource = null;
                dataGridAlat.DataSource = new ControllerMitra().GetAllAlat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data dashboard mitra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UserAddButton_Click(object sender, EventArgs e)
        {
            FormTambahAlat formTambah = new FormTambahAlat();
            if (formTambah.ShowDialog() == DialogResult.OK)
            {
                dataGridAlat.DataSource = null;
                dataGridAlat.DataSource = new ControllerMitra().GetAllAlat();
                this.Show();
            }

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (dataGridAlat.CurrentRow == null || dataGridAlat.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Silakan pilih alat yang ingin dihapus terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow barisPilihan = dataGridAlat.CurrentRow;
            object? idCell = barisPilihan.Cells["IdAlat"]?.Value;
            if (idCell == null || !int.TryParse(idCell.ToString(), out int idAlat) || idAlat <= 0)
            {
                MessageBox.Show("ID alat tidak valid atau kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaAlat = barisPilihan.Cells["NamaAlat"]?.Value?.ToString() ?? $"ID {idAlat}";
            DialogResult result = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus alat \"{namaAlat}\"?\n\nData mitra pemilik tidak akan terhapus.",
                "Konfirmasi Hapus Alat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                new ControllerMitra().deleteAlat(idAlat);
                MessageBox.Show("Alat berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridAlat.DataSource = null;
                dataGridAlat.DataSource = new ControllerMitra().GetAllAlat();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus alat: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Logut_Click(object sender, EventArgs e)
        {
            UserSession.Clear();
            this.Hide();
            using (FormLogin formLogin = new FormLogin())
            {
                formLogin.ShowDialog();
            }
            this.Close();
        }
    }
}
