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
    public partial class FormPinjam : Form
    {
        List<Alat> list_alat = new List<Alat>();

        public FormPinjam()
        {
            InitializeComponent();
            AlatGridBox.DataSource = new ControllerPeminjam().getAlatByStatus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AlatGridBox.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih alat terlebih dahulu!");
                return;
            }

            foreach (DataGridViewRow row in AlatGridBox.SelectedRows)
            {
                Alat alat = (Alat)row.DataBoundItem;

                if (!list_alat.Contains(alat))
                {
                    list_alat.Add(alat);
                }
            }

            AlatListBox.DataSource = null;
            AlatListBox.DataSource = list_alat;
        }
    }
}
