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
    public partial class DsbRiwayat : Form
    {
        public DsbRiwayat()
        {
            InitializeComponent();
            DataRiwayat.AutoGenerateColumns = true;
            loadRiwayat();
        }

        private void loadRiwayat()
        {
            string role = "Peminjam";
            if (UserSession.IdAdmin.HasValue && UserSession.IdAdmin > 0)
                role = "Admin";
            else if (UserSession.IdMitra.HasValue && UserSession.IdMitra > 0)
                role = "Mitra";

            DataRiwayat.DataSource = new Riwayat().getRiwayatJoin(role);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadRiwayat();
        }
    }
}
