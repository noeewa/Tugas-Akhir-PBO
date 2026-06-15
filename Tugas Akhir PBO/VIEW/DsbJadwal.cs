using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.Models;
using Tugas_Akhir_PBO.CONTROLLER;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DsbJadwal : Form
    {
        public DsbJadwal()
        {
            InitializeComponent();
            dataGridUser.AutoGenerateColumns = true;
            loadJadwal();
        }

        private void loadJadwal(string role = null)
        {
            if (role == null)
            {
                role = "Peminjam";
                if (UserSession.IdAdmin.HasValue && UserSession.IdAdmin > 0)
                    role = "Admin";
                else if (UserSession.IdMitra.HasValue && UserSession.IdMitra > 0)
                    role = "Mitra";
            }

            dataGridUser.DataSource = new Jadwal().getJadwalJoin(role);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            loadJadwal();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DetailPeminjaman_Click(object sender, EventArgs e)
        {
            if (dataGridUser.CurrentRow != null)
            {
                string idPeminjaman = dataGridUser.CurrentRow.Cells["IdPeminjaman"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(idPeminjaman))
                {
                    var detailForm = new DsbDetailPeminjaman(idPeminjaman);
                    if (detailForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
            }
        }
    }
}
