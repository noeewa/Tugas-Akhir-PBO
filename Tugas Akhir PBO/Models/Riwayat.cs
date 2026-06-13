using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Riwayat
{
    public string IdRiwayat { get; set; } = null!;

    public string? IdUser { get; set; }

    public string? IdPengembalian { get; set; }

    public string? IdPeminjaman { get; set; }

    public virtual Peminjaman? IdPeminjamanNavigation { get; set; }

    public virtual Pengembalian? IdPengembalianNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }

    public List<Riwayat> GetAllRiwayat()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Riwayats.ToList();
        }
    }

    public Riwayat GetRiwayatById(string idRiwayat)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Riwayats.Find(idRiwayat);
        }
    }

    public void inputRiwayat(string IdRiwayat, string IdUser, string IdPengembalian, string Peminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Riwayat riwayat = new Riwayat()
            {
                IdRiwayat = IdRiwayat,
                IdUser = IdUser,
                IdPengembalian = IdPengembalian,
                IdPeminjaman = Peminjaman
            };
            db.Riwayats.Add(riwayat);
            db.SaveChanges();
        }
    }

}
