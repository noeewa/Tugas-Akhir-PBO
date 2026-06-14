using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.CONTROLLER
{
    internal class ControllerPeminjam
    {
        public Peminjaman getJadwal()
        {
            string idUser = UserSession.UserId;
            return new Peminjaman().GetPeminjamanById(idUser);
        }

        public List<Alat> getAlatByStatus()
        {
            return new Alat().GetAlatByStatus();
        }
    }
}
