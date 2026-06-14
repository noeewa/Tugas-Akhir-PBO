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
    }
}
