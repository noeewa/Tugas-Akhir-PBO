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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DashboardPeminjam : Form
    {
        public DashboardPeminjam()
        {
            try
            {
                InitializeComponent();
                dataGridPeminjam.AutoGenerateColumns = true;
                dataGridPeminjam.DataSource = null;
                dataGridPeminjam.DataSource = new ControllerPeminjam().getJadwal();
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bPinjam_Click(object sender, EventArgs e)
        {
            if (new FormPinjam().ShowDialog() == DialogResult.OK)
            {
                dataGridPeminjam.DataSource = null;
                dataGridPeminjam.DataSource = new ControllerPeminjam().getJadwal();
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bPengembalian_Click(object sender, EventArgs e)
        {
            if (new FormPengembalian().ShowDialog() == DialogResult.OK)
            {
                dataGridPeminjam.DataSource = null;
                dataGridPeminjam.DataSource = new ControllerPeminjam().getJadwal();
                this.Show();
            }
        }
    }
}
