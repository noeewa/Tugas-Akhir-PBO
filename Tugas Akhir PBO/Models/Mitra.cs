using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Mitra : Abstarct_User
{
    public int Id { get; set; }

    public string? Nama { get; set; }

    public string? JenisMitra { get; set; }

    public string? Alamat { get; set; }

    public string? Kontak { get; set; }

    public string? Deskripsi { get; set; }

    public virtual ICollection<Alat> Alats { get; set; } = new List<Alat>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public override void insert()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Mitras.Add(this);
        }
    }

    public List<Mitra> GetAllMitra()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Mitras.ToList();
        }
    }
    public int GetMitraID()
    {
        using (var db = new TugasAkhirPboContext())
        {
            // 1. Ambil semua id_mitra langsung sebagai angka, urutkan dari yang terkecil
            var allIds = db.Mitras
                           .Select(m => m.Id)
                           .OrderBy(id => id)
                           .ToList();

            // 2. Jika database masih kosong (belum ada mitra sama sekali), mulai dari angka 0
            if (allIds.Count == 0)
            {
                return 0;
            }

            // 3. Cari angka/ID yang bolong mulai dari angka 1
            int targetAngka = 1;
            foreach (int idAktif in allIds)
            {
                // Jika ID di database melompati targetAngka,
                // artinya targetAngka tersebut hilang karena pernah dihapus
                if (idAktif != targetAngka)
                {
                    return targetAngka - 1; // Dikurangi 1 karena nanti saat Insert akan ditambah 1
                }
                targetAngka++;
            }

            // 4. Jika semua ID berurutan rapi tanpa ada yang bolong, kembalikan ID tertinggi saat ini
            return targetAngka - 1;
        }
    }
    public List<Object> AdminGetAllMitra()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Mitras.Select(u => new
            {
                // Tentukan kolom apa saja yang ingin diambil di sini:
                u.Id,
                u.Nama,
                u.Alamat,
                u.Alats,
                u.Deskripsi,
                u.Users
            })
            .ToList()          // Ubah ke List objek anonim
            .Cast<object>()    // Konversi agar sesuai dengan tipe data kembalian List<object>
            .ToList();
        }
    }

    public Mitra GetMitraById(int idMitra)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Mitras.Find(idMitra);
        }
    }

    public void insertMitra()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Mitras.Add(this);
            db.SaveChanges();
        }
    }

    public void updateMitra(int IdMitra, string NamaMitra, string JenisMitra, string Alamat, string Kontak, string Deskripsi)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Mitra mitra = new Mitra
            {
                Id = IdMitra,
                Nama = NamaMitra,
                JenisMitra = JenisMitra,
                Alamat = Alamat,
                Kontak = Kontak,
                Deskripsi = Deskripsi,
            };
            db.Mitras.Update(mitra);
            db.SaveChanges();
        }
    }

    public void deleteMitra(int idMitra)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var mitra = db.Mitras.Find(idMitra);
            db.Mitras.Remove(mitra);
            db.SaveChanges();
        }
    }
}
