using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Akhir_PBO.MODEL;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.CONTROLLER
{
    internal class ControllerPeminjam
    {
        public static Peminjaman getJadwal()
        {
            string idUser = UserSession.UserId;
            return new Peminjaman().GetPeminjamanById(idUser);
        }
    }
}
