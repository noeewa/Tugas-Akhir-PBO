using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class User
{
    public string IdUser { get; set; } = null!;

    public string? Nama { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? NoHp { get; set; }

    public string? Alamat { get; set; }

    public int? IdMitra { get; set; }

    public int? IdPeminjam { get; set; }

    public int? IdAdmin { get; set; }

    public virtual Admin? IdAdminNavigation { get; set; }

    public virtual Mitra? IdMitraNavigation { get; set; }

    public virtual Peminjam? IdPeminjamNavigation { get; set; }

    public virtual ICollection<Peminjaman> Peminjamen { get; set; } = new List<Peminjaman>();

    public virtual ICollection<Riwayat> Riwayats { get; set; } = new List<Riwayat>();

    public User getUser(string username, string password)
    {
        using (var db = new TugasAkhirPboContext())
        {
            //var semua = db.Users.ToList();
            //MessageBox.Show("Total user: " + semua.Count); //debug

            var user = db.Users.FirstOrDefault(u => u.Nama == username && u.Password == password); ;
            return user;
        }
    }
    public List<User> GetAllUser()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Users.ToList();
        }
    }
    public List<Object> GetAllUserAdmin()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Users
            .Select(u => new
            {
                // Tentukan kolom apa saja yang ingin diambil di sini:
                u.IdUser,
                u.Password,
                u.Nama,
                u.Email,
                u.NoHp,
                u.IdPeminjam,
                u.IdAdmin,
                u.IdMitra
            })
            .ToList()          // Ubah ke List objek anonim
            .Cast<object>()    // Konversi agar sesuai dengan tipe data kembalian List<object>
            .ToList();
        }
    }
    public List<object> GetAllPeminjamAdmin()
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Users
                // 1. Filter: Hanya ambil user yang memiliki IdPeminjam (bukan null dan bukan 0)
                .Where(u => u.IdPeminjam != null && u.IdPeminjam != 0)

                // 2. Pilih kolom yang dibutuhkan
                .Select(u => new
                {
                    u.IdUser,
                    u.Password,
                    u.Nama,
                    u.Email,
                    u.NoHp,
                    u.IdPeminjam,
                    u.IdAdmin,
                    u.IdMitra
                })
                .ToList()
                .Cast<object>()
                .ToList();
        }
    }


    public int getLastID()
    {
        using (var db = new TugasAkhirPboContext())
        {
            // 1. Ambil semua ID dari database dan urutkan dari yang terkecil (A-Z)
            var allIds = db.Users
                           .Select(u => u.IdUser)
                           .OrderBy(id => id)
                           .ToList();

            // 2. Jika database benar-benar kosong, maka ID pertama harus dimulai dari angka 0 
            // (nanti saat ditambah 1 di fungsi insert akan menjadi "USR-001")
            if (allIds.Count == 0)
            {
                return 0;
            }

            // 3. Ekstrak semua string ID menjadi daftar angka (integer)
            List<int> daftarAngka = new List<int>();
            foreach (var id in allIds)
            {
                if (id.Length > 4 && int.TryParse(id.Substring(4), out int angka))
                {
                    daftarAngka.Add(angka);
                }
            }

            // 4. Cari angka yang hilang (celah kosong) mulai dari angka 1
            int targetAngka = 1;
            foreach (int angkaAktif in daftarAngka)
            {
                // Jika angka yang ada di database tidak sama dengan targetAngka kita,
                // artinya targetAngka tersebut sedang "hilang/dihapus"
                if (angkaAktif != targetAngka)
                {
                    // Kembalikan (targetAngka - 1) karena di luar fungsi ini 
                    // Anda akan menambahkannya dengan +1 lagi.
                    return targetAngka - 1;
                }
                targetAngka++;
            }

            // 5. Jika tidak ada angka yang bolong di tengah, 
            // kembalikan angka tertinggi yang ada saat ini
            return targetAngka - 1;
        }
    }

    public User GetUserById(string idUser)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Users.Find(idUser);
        }
    }
    public User MitraUpdateUserById(int idMitra, string idUser)
    {
        using (var db = new TugasAkhirPboContext())
        {
            // 1. Cari user berdasarkan idUser
            var user = db.Users.Find(idUser);

            // 2. Validasi apakah user tersebut ditemukan
            if (user != null)
            {
                // 3. Update properti id_mitra dengan nilai baru dari parameter
                user.IdMitra = idMitra;

                // 4. Simpan perubahan ke database PostgreSQL
                db.SaveChanges();
            }

            // 5. Kembalikan objek user yang sudah ter-update (atau null jika tidak ketemu)
            return user;
        }
    }
    public void insertUser()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Users.Add(this);
            db.SaveChanges();
        }
    }

    public void updateUser(string IdUser, string Nama, string Email, string Password, string NoHp, string Alamat, int IdMitra, int IdPeminjam, int IdAdmin)
    {
        using (var db = new TugasAkhirPboContext())
        {
            User user = new User
            {
                IdUser = IdUser,
                Nama = Nama,
                Email = Email,
                Password = Password,
                NoHp = NoHp,
                Alamat = Alamat,
                IdMitra = IdMitra,
                IdPeminjam = IdPeminjam,
                IdAdmin = IdAdmin
            };
            db.Users.Update(user);
            db.SaveChanges();
        }
    }

    public void deleteUser(string idUser)
    {
        using (var db = new TugasAkhirPboContext())
        {
            var user = db.Users.Find(idUser);
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}