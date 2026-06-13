using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Peminjaman
{
    public string IdPeminjaman { get; set; } = null!;

    public string? IdUser { get; set; }

    public string? DetailPeminjaman { get; set; }

    public string? TanggalPeminjaman { get; set; }

    public string? TanggalKembali { get; set; }

    public virtual User? IdUserNavigation { get; set; }

    public virtual ICollection<Jadwal> Jadwals { get; set; } = new List<Jadwal>();

    public virtual Pengembalian? Pengembalian { get; set; }

    public virtual ICollection<Riwayat> Riwayats { get; set; } = new List<Riwayat>();

    public List<Peminjaman> GetAllPeminjaman()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Peminjamen.ToList();
        }
    }

    public Peminjaman GetPeminjamanById(string idUser)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Peminjamen.FirstOrDefault(u => u.IdUser == idUser);
        }
    }

    public void inputPeminjaman(string IdPeminjaman, string IdUser, string DetailPeminjaman, string TanggalKembali, string TanggalPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Peminjaman peminjaman = new Peminjaman()
            {
                IdPeminjaman = IdPeminjaman,
                IdUser = IdUser,
                DetailPeminjaman = DetailPeminjaman,
                TanggalKembali = TanggalKembali,
                TanggalPeminjaman = TanggalPeminjaman
            };
            db.Peminjamen.Add(peminjaman);
            db.SaveChanges();
        }
    }

    public void deletePeminjaman(string idPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var peminjaman = db.Peminjamen.Find(idPeminjaman);
            db.Peminjamen.Remove(peminjaman);
            db.SaveChanges();
        }
    }
}
