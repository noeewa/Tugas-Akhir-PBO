using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.CONTROLLER
{
    internal class ControllerMitra
    {
        public List<KategoriAlat> getKategori()
        {

            List<KategoriAlat> kategori = new KategoriAlat().GetKategori();
            return kategori;
        }
        public int? getMitra()
        {
            //MessageBox.Show($"UserSession.UserId = '{UserSession.UserId}'");
            int? idMitra = new User().GetUserById(UserSession.UserId).IdMitra;
            return idMitra;
        }
        public List<object> GetAllAlat()
        {
            List<object> alat = new Alat().getAlat(this.getMitra());
            return alat;
        }
        public void deleteAlat(int IdAlat)
        {
            new Alat().deleteAlat(IdAlat);
        }
        public Alat TambahAlat(Alat alatRegis)
        {
            alatRegis.IdMitra = this.getMitra();
            return alatRegis.inputAlat();
        }

    }
}
