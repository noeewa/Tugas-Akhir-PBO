using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Tugas_Akhir_PBO.Models;

public partial class Pengembalian
{
    public string IdPengembalian { get; set; } = null!;

    public string? IdPeminjaman { get; set; }

    public DateOnly? TanggalPengembalian { get; set; }

    public string? KondisiAlat { get; set; }

    public string? Denda { get; set; }

    public virtual Peminjaman? IdPeminjamanNavigation { get; set; }

    public virtual ICollection<Riwayat> Riwayats { get; set; } = new List<Riwayat>();

    public List<Pengembalian> GetAllPengembalianWithPeminjaman()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Pengembalians
                .Include(p => p.IdPeminjamanNavigation)
                .Include(p => p.Riwayats)
                .ToList();
        }
    }

    public List<Pengembalian> GetAllPengembalianWithPeminjamanConfirmed()
    {
        using (var db = new TugasAkhirPboContext())
        {
            var pengembalianIds = db.Riwayats
                .Where(r => r.IdPengembalian != null)
                .Select(r => r.IdPengembalian)
                .Distinct()
                .ToList();

            return db.Pengembalians
                .Include(p => p.IdPeminjamanNavigation)
                .Where(p => !pengembalianIds.Contains(p.IdPengembalian))
                .ToList();
        }
    }

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
