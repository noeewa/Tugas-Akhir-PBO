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
    public partial class FormPinjam : Form
    {
        public FormPinjam()
        {
            InitializeComponent();
            AlatGridBox.DataSource = new ControllerPeminjam().getAlatByStatus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
