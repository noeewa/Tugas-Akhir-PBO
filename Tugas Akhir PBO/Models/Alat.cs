using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Alat
{
    public int IdAlat { get; set; }

    public string? NamaAlat { get; set; }

    public string? Kategori { get; set; }

    public string? Kondisi { get; set; }

    public string? Deskripsi { get; set; }

    public bool? Status { get; set; }

    public int? IdMitra { get; set; }

    public virtual Mitra? IdMitraNavigation { get; set; }

    public virtual ICollection<Jadwal> Jadwals { get; set; } = new List<Jadwal>();

    public virtual KategoriAlat? KategoriNavigation { get; set; }

    public Admin getAdmin(int id_admin)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Admins.FirstOrDefault(u => u.Id == id_admin);
        }
    }

    //status

    public List<Alat> GetAllAlat()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Alats.ToList();
        }
    }
    public List<object> getAlat(int? idMitra)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Alats
                .Select(a => new
                {
                    // Pilih hanya properti/kolom yang ingin ditampilkan di DataGridView
                    a.IdAlat,
                    a.NamaAlat,
                    a.Kategori,
                    a.Kondisi,
                    a.Deskripsi,
                    a.Status,
                    a.IdMitra
                })
                .ToList()          // Ubah ke List objek anonim
                .Cast<object>()    // Konversi agar sesuai dengan tipe data kembalian List<object>
                .ToList();
        }
    }

    public Alat inputAlat()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Alats.Add(this);
            db.SaveChanges();
            return this;
        }
    }

    public Alat updateAlat(int IdAlat, string NamaAlat, string kategori, string Kondisi, string Deskripsi, bool status, int IdMitra)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Alat alat = new Alat
            {
                IdAlat = IdAlat,
                NamaAlat = NamaAlat,
                Kategori = kategori,
                Kondisi = Kondisi,
                Deskripsi = Deskripsi,
                Status = status,
                IdMitra = IdMitra
            };

            db.Alats.Update(alat);
            db.SaveChanges();
            return alat;
        }
    }

    public Alat deleteAlat(int IdAlat)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var alat = db.Alats.Find(IdAlat);
            db.Alats.Remove(alat);
            db.SaveChanges();
            return alat;
        }
    }
}
