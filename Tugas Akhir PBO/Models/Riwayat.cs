using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tugas_Akhir_PBO.CONTROLLER;

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
            return db.Riwayats
                .Include(r => r.IdPeminjamanNavigation)
                .Include(r => r.IdPengembalianNavigation)
                .Include(r => r.IdUserNavigation)
                .ToList();
        }
    }

    public Riwayat GetRiwayatById(string idRiwayat)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Riwayats.Find(idRiwayat);
        }
    }

    public List<Object> getRiwayatJoin(string role)
        {
            using (var db = new TugasAkhirPboContext())
            {
                var query = db.Riwayats
                    .Include(r => r.IdUserNavigation)
                    .Include(r => r.IdPeminjamanNavigation)
                    .Include(r => r.IdPengembalianNavigation)
                    .Select(r => new
                    {
                        NamaUser = r.IdUserNavigation.Nama,
                        IdPeminjaman = r.IdPeminjaman ?? "",
                        TanggalMulai = r.IdPeminjamanNavigation != null ? r.IdPeminjamanNavigation.TanggalPeminjaman ?? "" : "",
                        TanggalKembali = r.IdPengembalianNavigation != null && r.IdPengembalianNavigation.TanggalPengembalian != null ? r.IdPengembalianNavigation.TanggalPengembalian.Value.ToString("yyyy-MM-dd") : "",
                        Alat = r.IdPeminjamanNavigation != null ? r.IdPeminjamanNavigation.DetailPeminjaman : ""
                    });

            if (role != "Admin")
                {
                    query = query.Where(r => r.NamaUser == UserSession.Username);
                }

                return query.ToList().Cast<object>().ToList();
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
