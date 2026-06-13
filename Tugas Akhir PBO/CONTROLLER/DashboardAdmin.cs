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
        public static Mitra formDaftarMitra(Mitra mitra, string idUser)
        {

            mitra.insertMitra();
            new User().MitraUpdateUserById(mitra.IdMitra, idUser);
            MessageBox.Show($"Mitra {mitra.NamaMitra} Berhasil Ditambah");
            return mitra;
        }
    }
}
