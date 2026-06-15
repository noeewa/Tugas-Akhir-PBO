using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DsbRiwayat : Form
    {
        public DsbRiwayat()
        {
            InitializeComponent();
            DataRiwayat.DataSource = new Riwayat().GetAllRiwayat();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }
    }
}
