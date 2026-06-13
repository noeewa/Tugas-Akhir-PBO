using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Jadwal
{
    public string IdJadwal { get; set; } = null!;

    public int IdAlat { get; set; } = 0;

    public DateOnly? TanggalMulai { get; set; }

    public DateOnly? TanggalSelesai { get; set; }

    public string? StatusJadwal { get; set; }

    public string? IdPeminjaman { get; set; }

    public virtual Alat IdAlatNavigation { get; set; } = null!;

    public List<Jadwal> getJadwal(string IdPeminjam)
    {
        using(var db = new TugasAkhirPboContext())
        {
            return db.Jadwals.ToList();
        }
    }
    public Jadwal inputJadwal(string idJadwal, int idAlat, DateOnly? tanggalMulai, DateOnly? tanggalSelesai, string? statusJadwal, string? idPeminjaman)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Jadwal jadwal = new Jadwal
            {
                IdJadwal = idJadwal,
                IdAlat = idAlat,
                TanggalMulai = tanggalMulai,
                TanggalSelesai = tanggalSelesai,
                StatusJadwal = statusJadwal,
                IdPeminjaman = idPeminjaman
            };

            db.Jadwals.Add(jadwal);
            db.SaveChanges();

            return jadwal;
        }
    }
}
