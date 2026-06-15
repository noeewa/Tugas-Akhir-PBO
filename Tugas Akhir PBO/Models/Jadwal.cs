using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Tugas_Akhir_PBO.CONTROLLER;

namespace Tugas_Akhir_PBO.Models;

public partial class Jadwal
{
    public string IdJadwal { get; set; } = null!;

    public int? IdAlat { get; set; }

    public string? IdPeminjaman { get; set; }

    public DateOnly? TanggalMulai { get; set; }

    public DateOnly? TanggalSelesai { get; set; }

    public virtual Alat? IdAlatNavigation { get; set; }

    public virtual Peminjaman? IdPeminjamanNavigation { get; set; }

    public List<Object> getJadwalJoin(string role)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var query = db.Jadwals
                .Include(j => j.IdPeminjamanNavigation)
                .Select(j => new
                {
                    NamaUser = (j.IdPeminjamanNavigation != null && j.IdPeminjamanNavigation.IdUserNavigation != null)
                        ? j.IdPeminjamanNavigation.IdUserNavigation.Nama
                        : "",
                    TanggalMulai = j.TanggalMulai,
                    TanggalKembali = j.TanggalSelesai,
                    IdPeminjaman = j.IdPeminjaman ?? ""
                });

            if (role != "Admin")
            {
                query = query.Where(j => j.NamaUser == UserSession.Username);
            }

            return query.ToList().Cast<object>().ToList();
        }
    }

    public Jadwal getDetailPeminjaman(string IdPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var detailPeminjaman = db.Jadwals.Find(IdPeminjaman);
            return detailPeminjaman;
        }
    }
    public List<Jadwal> getJadwal(string IdPeminjam)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Jadwals.ToList();
        }
    }
    public Jadwal inputJadwal(string? idJadwal, int idAlat, DateOnly? tanggalMulai, DateOnly? tanggalSelesai, string? idPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Jadwal jadwal = new Jadwal
            {
                IdJadwal = idJadwal,
                IdAlat = idAlat,
                TanggalMulai = tanggalMulai,
                TanggalSelesai = tanggalSelesai,
                IdPeminjaman = idPeminjaman
            };

            db.Jadwals.Add(jadwal);
            db.SaveChanges();

            return jadwal;
        }
    }

    public KategoriAlat inputKategoriAlat(string IdKategori, string NamaKategori, string Deskripsi)
    {
        using (var db = new TugasAkhirPboContext())
        {
            KategoriAlat kategoriAlat = new KategoriAlat()
            {
                IdKategori = IdKategori,
                NamaKategori = NamaKategori,
                Deskripsi = Deskripsi,
            };

            db.KategoriAlats.Add(kategoriAlat);
            db.SaveChanges();
            return kategoriAlat;
        }
    }

    public KategoriAlat updateKategoriAlat(string IdKategori, string NamaKategori, string Deskripsi)
    {
        using (var db = new TugasAkhirPboContext())
        {
            KategoriAlat kategoriAlat = new KategoriAlat()
            {
                IdKategori = IdKategori,
                NamaKategori = NamaKategori,
                Deskripsi = Deskripsi,
            };
            var kategori = db.KategoriAlats.Find(kategoriAlat.IdKategori);
            db.KategoriAlats.Update(kategori);
            db.SaveChanges();
            return kategoriAlat;
        }
    }

    public KategoriAlat deleteKategoriAlat(string IdKategori, string NamaKategori, string Deskripsi)
    {
        using (var db = new TugasAkhirPboContext())
        {
            KategoriAlat kategoriAlat = new KategoriAlat()
            {
                IdKategori = IdKategori,
                NamaKategori = NamaKategori,
                Deskripsi = Deskripsi,
            };
            var kategori = db.KategoriAlats.Find(kategoriAlat.IdKategori);
            db.KategoriAlats.Remove(kategori);
            db.SaveChanges();
            return kategoriAlat;
        }
    }
}
