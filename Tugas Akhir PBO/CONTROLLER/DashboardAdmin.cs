using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.CONTROLLER
{
    internal class ControllerAdmin
    {

        public static List<Object> getUser()
        {
            return new User().GetAllUserAdmin();
        }
        public static List<Mitra> getMitra()
        {
            return new Mitra().GetAllMitra();
        }
        public static void DelUser(string idUser)
        {
            User userDel = new User();
            userDel.deleteUser(idUser);
        }
        public static List<Object> GetAllUserAdmin()
        {
            return new User().GetAllUserAdmin();
        }
        public static List<Object> AdminGetMitra()
        {
            return new Mitra().AdminGetAllMitra();
        }
        public static void DelMitra(int idMitra)
        {
            // Update users status back to peminjam (set IdMitra = null)
            using (var db = new TugasAkhirPboContext())
            {
                var users = db.Users.Where(u => u.IdMitra == idMitra).ToList();
                foreach (var u in users)
                {
                    u.IdMitra = null;
                }
                db.SaveChanges();
            }

            // Delete Mitra
            Mitra m = new Mitra();
            m.deleteMitra(idMitra);
        }
        public static Mitra formDaftarMitra(Mitra mitra, string idUser)
        {

            mitra.insertMitra();
            new User().MitraUpdateUserById(mitra.Id, idUser);
            MessageBox.Show($"Mitra {mitra.Nama} Berhasil Ditambah");
            return mitra;
        }
    }
}
