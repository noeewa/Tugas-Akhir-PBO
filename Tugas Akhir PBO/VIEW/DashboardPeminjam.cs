using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;
using Tugas_Akhir_PBO.VIEW;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DashboardPeminjam : Form
    {
        public DashboardPeminjam()
        {
            try
            {
                InitializeComponent();
                dataGridUser.AutoGenerateColumns = false;
                dataGridUser.DataSource = ControllerPeminjam.getJadwal();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bPinjam_Click(object sender, EventArgs e)
        {
            if (new FormPinjam().ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void bPengembalian_Click(object sender, EventArgs e)
        {
            if (new FormPengembalian().ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
