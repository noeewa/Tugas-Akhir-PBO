using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class KategoriAlat
{
    public string IdKategori { get; set; } = null!;

    public string? NamaKategori { get; set; }

    public string? Deskripsi { get; set; }

    public virtual ICollection<Alat> Alats { get; set; } = new List<Alat>();

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
