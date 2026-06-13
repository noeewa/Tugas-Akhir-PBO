using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Pengembalian
{
    public string IdPengembalian { get; set; } = null!;

    public string IdPeminjaman { get; set; } = null!;

    public DateOnly? TanggalPengembalian { get; set; }

    public string? KondisiAlat { get; set; }

    public string? Denda { get; set; }

    public virtual Peminjaman IdPeminjamanNavigation { get; set; } = null!;

    public virtual ICollection<Riwayat> Riwayats { get; set; } = new List<Riwayat>();

    public List<Pengembalian> GetAllPengembalian()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Pengembalians.ToList();
        }
    }

    public Pengembalian GetPengembalianById(string idPengembalian)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Pengembalians.Find(idPengembalian);
        }
    }

    public void inputPengembalian(string IdPengembalian, string IdPeminjaman, DateOnly TanggalPengembalian, string KondisiAlat, string Denda)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Pengembalian pengembalian = new Pengembalian()
            {
                IdPeminjaman = IdPeminjaman,
                IdPengembalian = IdPengembalian,
                TanggalPengembalian = TanggalPengembalian,
                KondisiAlat = KondisiAlat,
                Denda = Denda
            };
            db.Pengembalians.Add(pengembalian);
            db.SaveChanges();
        }
    }
}