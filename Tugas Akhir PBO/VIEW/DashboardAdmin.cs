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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {

            try
            {
                InitializeComponent();
                dataGridUser.DataSource = ControllerAdmin.getUser();
                dataGridUser.AutoGenerateColumns = false;
                dataGridMitra.DataSource = ControllerAdmin.AdminGetMitra();
                dataGridMitra.AutoGenerateColumns = false;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void LabelLinkBarang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void UserAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {            
            if (dataGridUser.CurrentRow != null)
            {
                DataGridViewRow barisPilihan = dataGridUser.CurrentRow;

                string idUser = barisPilihan.Cells["IdUser"]?.Value?.ToString();

                if (string.IsNullOrEmpty(idUser))
                {
                    MessageBox.Show("ID User tidak valid atau kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus user dengan ID: {idUser}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ControllerAdmin.DelUser(idUser);

                        MessageBox.Show("User berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridUser.DataSource = null;
                        dataGridUser.DataSource = ControllerAdmin.GetAllUserAdmin();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menghapus: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan klik salah satu baris user di tabel terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UserAddButton_Click(object sender, EventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            if (formDaftar.ShowDialog() == DialogResult.OK)
            {
                dataGridUser.DataSource = null;
                dataGridUser.DataSource = ControllerAdmin.GetAllUserAdmin();
                this.Show();
            }
        }

        private void DaftarMitra_Click(object sender, EventArgs e)
        {
            FormDaftarMitra formDaftar = new FormDaftarMitra();
            if (formDaftar.ShowDialog() == DialogResult.OK)
            {
                dataGridMitra = null;
                dataGridMitra.DataSource = ControllerAdmin.AdminGetMitra();
                this.Show();
            }
        }

        private void HapusMitra_Click(object sender, EventArgs e)
        {

        }

        private void LabelLinkPeminjaman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridMitra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
