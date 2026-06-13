using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Peminjam
{
    public int IdPeminjam { get; set; }

    public string? Alamat { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public void inputPeminjam(string Alamat)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Peminjam peminjam = new Peminjam()
            {
                IdPeminjam = IdPeminjam,
                Alamat = Alamat
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
                           .Select(p => p.IdPeminjam)
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
