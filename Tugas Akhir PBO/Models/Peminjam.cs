using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Peminjam : Abstarct_User
{
    public int Id { get; set; }

    public string Nama { get; set; } = null!;

    public string? Alamat { get; set; }

    public string? Kontak { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public override void insert()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Peminjams.Add(this);
        }
    }

    public void inputPeminjam(string Nama, string Alamat, string Kontak)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Peminjam peminjam = new Peminjam()
            {
                Id = Id,
                Nama = Nama,
                Alamat = Alamat,
                Kontak = Kontak
            };
            db.Peminjams.Add(peminjam);
            db.SaveChanges();
        }
    }
    public int getLastId()
    {
        using (var db = new TugasAkhirPboContext())
        {
            // 1. Ambil semua IdPeminjam langsung sebagai angka, urutkan dari terkecil
            var allIds = db.Peminjams
                           .Select(p => p.Id)
                           .OrderBy(id => id)
                           .ToList();

            // 2. Jika database masih kosong, mulai dari angka 0
            if (allIds.Count == 0)
            {
                return 0;
            }

            // 3. Cari angka/id yang bolong mulai dari angka 1
            int targetAngka = 1;
            foreach (int idAktif in allIds)
            {
                // Jika ID di database melompati targetAngka, 
                // artinya targetAngka tersebut hilang karena pernah dihapus
                if (idAktif != targetAngka)
                {
                    return targetAngka - 1; // Dikurangi 1 karena nanti di fungsi Insert akan ditambah 1
                }
                targetAngka++;
            }

            // 4. Jika semua berurutan rapi tanpa ada yang dihapus, kembalikan ID tertinggi
            return targetAngka - 1;
        }
    }

    public List<Peminjam> getAllPeminjam()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Peminjams.ToList();
        }
    }

}
