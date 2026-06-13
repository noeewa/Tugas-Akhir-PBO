
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Akhir_PBO.MODEL;
using Tugas_Akhir_PBO.Models;
using Tugas_Akhir_PBO.VIEW;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tugas_Akhir_PBO.CONTROLLER
{
    class UseController
    {
        public static User formLogin(string username, string password)
        {
            User user = new User().getUser(username, password);

            if (user == null)
            {
                MessageBox.Show("Username atau password salah!");
                return null;
            } else
            {
                UserSession.UserId = user.IdUser;
                UserSession.Username = user.Nama;
                UserSession.IdMitra = user.IdMitra;
                UserSession.IdAdmin = user.IdAdmin;
                UserSession.IdPeminjam = user.IdPeminjam;
                return user;
            }

            
        }
        public static User formDaftarPeminjam(User user)
        {
            Peminjam peminjamRegis = new Peminjam();
            peminjamRegis.inputPeminjam(user.Alamat);

            int last_id = user.getLastID();
            string idUser = "USR-" + last_id.ToString("D3");

            User userRegis = new User()
            {
                IdUser = idUser,
                Nama = user.Nama,
                Email = user.Email,
                Password = user.Password,
                NoHp = user.NoHp,
                Alamat = user.Alamat,
                IdPeminjam = peminjamRegis.getLastId()
            };

            userRegis.insertUser();
            return userRegis;
        }


        public static Admin TabelAdmin(int id_admin)
        {
            Admin admin = new Admin();
            admin.getAdmin(id_admin);
            if (int.IsNegative(admin.IdAdmin))
            {
                return null;
            }
            else
            {
                return admin;
            }
        }
    }

}
