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
    public partial class FormDaftar : Form
    {
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NamaBox.Text) || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            User user = new User()
            {
                Nama = NamaBox.Text,
                Emails = EmailBox.Text,
                Pass = PasswordBox.Text,
            };

            UseController.formDaftarPeminjam(user);
            MessageBox.Show("Registrasi berhasil!");
            this.DialogResult = DialogResult.OK;


        }
    }
}
