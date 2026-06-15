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
    public partial class DsbAlat : Form
    {
        public DsbAlat()
        {
            InitializeComponent();
            DataAlats.AutoGenerateColumns = true;
            loadAlat();
        }

        private void loadAlat()
        {
            DataAlats.DataSource = new Alat().GetAllAlat();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            loadAlat();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
