using Microsoft.VisualBasic.Logging;
using Npgsql;
using Tugas_Akhir_PBO.CONTROLLER;
using Tugas_Akhir_PBO.Models;
using Tugas_Akhir_PBO.VIEW;

namespace Tugas_Akhir_PBO
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            //this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Gambar\Background Hijau.png");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!");
                return;
            }

            User user = UseController.formLogin(UsernameBox.Text, PasswordBox.Text);
            if (user != null && string.IsNullOrEmpty(user.Nama))
            {
               
                MessageBox.Show($"username: {user.Nama}");
            }
            if (user == null)
            {
                MessageBox.Show("Username atau password salah!");
                return;
            }

            MessageBox.Show("Selamat datang, " + user.Nama);
            this.Hide();

            if (user.IdAdmin > 0)
                new DashboardAdmin().ShowDialog();
            else if (user.IdMitra > 0)
                new DashboardMitra().ShowDialog();
            else if (user.IdPeminjam > 0)
                new DashboardPeminjam().ShowDialog();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDaftar formdaftar = new FormDaftar();
            this.Hide();

            // Jalankan form daftar sebagai dialog tunggal
            if (formdaftar.ShowDialog() == DialogResult.OK)
            {
                // Jika tombol di form daftar mengirim sinyal DialogResult.OK
                // Tampilkan kembali form ini
                this.Show();
            }
            else
            {
                // Jika user menutup form daftar tanpa daftar (Klik X atau Cancel)
                Application.Exit(); // Atau Application.Exit() tergantung skenario Anda
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void JConsoleDaftar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
