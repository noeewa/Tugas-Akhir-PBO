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
    public partial class FormDaftarMitra : Form
    {
        public FormDaftarMitra()
        {
            InitializeComponent();
            List<Object> list_user = new User().GetAllPeminjamAdmin();
            UserDropDown.DisplayMember = "Nama";
            UserDropDown.ValueMember = "IdUser";
            UserDropDown.DataSource = list_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Mitra regisMitra = new Mitra()
            {
                NamaMitra = NamaBox.Text,
                JenisMitra = JenisBox.Text,
                Alamat = AlamatTextBox.Text,
                Deskripsi = DeskripsiBox.Text,
                Kontak = NomorHpBox.Text

            };
            if (UserDropDown.SelectedValue != null)
            {
                string idUserTerpilih = UserDropDown.SelectedValue.ToString();
                ControllerAdmin.formDaftarMitra(regisMitra, idUserTerpilih);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Silakan pilih user terlebih dahulu!");
            }


        }
    }
}
