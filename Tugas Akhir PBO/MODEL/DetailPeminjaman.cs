using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class DetailPeminjaman
{
    public string? IdJadwal { get; set; }

    public string? IdPeminjaman { get; set; }

    public int? IdAlat {  get; set; }

    public virtual Jadwal? IdJadwalNavigation { get; set; }

    public virtual Peminjaman? IdPeminjamanNavigation { get; set; }

    public DetailPeminjaman getDetailPeminjaman(string IdPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var detailPeminjaman = db.DetailPeminjamen.Find(IdPeminjaman);
            return detailPeminjaman;
        }
    }

    public DetailPeminjaman inputDetailPeminajam(string IdJadwal, string IdPeminjaman, int IdAlat)
    {
        using (var db = new TugasAkhirPboContext())
        {
            DetailPeminjaman detailPeminjaman = new DetailPeminjaman
            {
                IdAlat = IdAlat,
                IdPeminjaman = IdPeminjaman,
                IdJadwal = IdJadwal,
            };
            db.DetailPeminjamen.Add(detailPeminjaman);
            db.SaveChanges();
            return detailPeminjaman;
        }
    }
}
