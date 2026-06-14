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
    public partial class FormTambahAlat : Form
    {
        public FormTambahAlat()
        {
            InitializeComponent();
            KategoriCBox.DisplayMember = "NamaKategori";
            KategoriCBox.ValueMember = "IdKategori";
            KategoriCBox.DataSource = new ControllerMitra().getKategori();
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Alat alatRegis = new Alat()
            {
                NamaAlat = NamaBox.Text,
                Kondisi = KondisiBox.Text,
                Kategori = KategoriCBox.SelectedValue.ToString(),
                Status = false,
                Deskripsi = DeskripsiText.Text,
            };
            new ControllerMitra().TambahAlat(alatRegis);
            MessageBox.Show("Alat Berhasil Ditambahkan");
            this.DialogResult = DialogResult.OK;
        }
    }
}
