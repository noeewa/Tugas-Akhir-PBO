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
    public partial class DashboardMitra : Form
    {
        public DashboardMitra()
        {


            try
            {
                InitializeComponent();
                dataGridAlat.DataSource = new ControllerMitra().GetAllAlat;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void UserAddButton_Click(object sender, EventArgs e)
        {
            FormTambahAlat formTambah = new FormTambahAlat();
            if (formTambah.ShowDialog() == DialogResult.OK)
            {
                dataGridAlat.DataSource = null;
                dataGridAlat.DataSource = new ControllerMitra().GetAllAlat();
                this.Show();
            }

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (dataGridAlat.CurrentRow != null)
            {
                // Gunakan CurrentRow karena lebih aman daripada SelectedRows[0] 
                // CurrentRow akan selalu mengambil baris tempat kursor/klik Anda berada
                DataGridViewRow barisPilihan = dataGridAlat.CurrentRow;

                // 2. AMAT PENTING: Sesuaikan nama kolom dengan properti C# (PascalCase) 
                // Tambahkan tanda tanya (?) untuk mencegah error jika nilainya ternyata null
                int idAlat = Convert.ToInt32(barisPilihan.Cells["IdAlat"].Value);

                // Jika Anda masih ragu nama kolomnya apa, Anda bisa menggunakan angka indeks kolom pertama:
                // string idUser = barisPilihan.Cells[0].Value?.ToString();

                if (idAlat > 0)
                {
                    MessageBox.Show("ID User tidak valid atau kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Tampilkan konfirmasi sebelum hapus
                DialogResult result = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus user dengan ID: {idAlat}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // 4. Eksekusi Hapus via Controller
                        new ControllerMitra().deleteAlat(idAlat);

                        MessageBox.Show("User berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Panggil fungsi refresh yang kita buat sebelumnya agar data di grid langsung hilang
                        dataGridAlat.DataSource = null;
                        dataGridAlat.DataSource = new ControllerMitra().GetAllAlat();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Gagal menghapus: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan klik salah satu baris user di tabel terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
