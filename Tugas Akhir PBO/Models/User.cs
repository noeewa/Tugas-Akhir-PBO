using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class User
{
    private string IdUser { get; set; } = null!;

    private string? Username { get; set; }

    private string? Email { get; set; }

    private string? Password { get; set; }

    public int? IdAdmin { get; set; }

    public int? IdMitra { get; set; }

    public int? IdPeminjam { get; set; }

    public virtual Admin? IdAdminNavigation { get; set; }

    public virtual Mitra? IdMitraNavigation { get; set; }

    public virtual Peminjam? IdPeminjamNavigation { get; set; }

    public virtual ICollection<Peminjaman> Peminjamen { get; set; } = new List<Peminjaman>();

    public virtual ICollection<Riwayat> Riwayats { get; set; } = new List<Riwayat>();

    public string Id
    {
        get { return this.IdUser; }
        set { IdUser = value; }
    }
    public string Nama
    {
        get { return Username; }
        set { Username = value; }
    }
    public string Pass
    {
        get { return Password; }
        set { Password = value; }
    }
    public string Emails
    {
        get { return Email; }
        set { Email = value; }
    }
    public User getUser(string username, string password)
    {
        using (var db = new TugasAkhirPboContext())
        {
            //var semua = db.Users.ToList();
            //MessageBox.Show("Total user: " + semua.Count); //debug

            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password); ;
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
                u.Username,
                u.Email,
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
             
                .Where(u => u.IdPeminjam != null && u.IdPeminjam != 0)

                .Select(u => new
                {
                    u.IdUser,
                    u.Password,
                    u.Username,
                    u.Email,
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
   
            var allIds = db.Users
                           .Select(u => u.IdUser)
                           .OrderBy(id => id)
                           .ToList();

      
            if (allIds.Count == 0)
            {
                return 0;
            }

        
            List<int> daftarAngka = new List<int>();
            foreach (var id in allIds)
            {
                if (id.Length > 4 && int.TryParse(id.Substring(4), out int angka))
                {
                    daftarAngka.Add(angka);
                }
            }

           
            int targetAngka = 1;
            foreach (int angkaAktif in daftarAngka)
            {
             
                if (angkaAktif != targetAngka)
                {
         
                    return targetAngka - 1;
                }
                targetAngka++;
            }

        
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
   
            var user = db.Users.Find(idUser);

            if (user != null)
            {
         
                user.IdMitra = idMitra;
                db.SaveChanges();
            }

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

    public void updateUser(string IdUser, string username, string Email, string Password, string NoHp, string Alamat, int IdMitra, int IdPeminjam, int IdAdmin)
    {
        using (var db = new TugasAkhirPboContext())
        {
            User user = new User
            {
                IdUser = IdUser,
                Username = username,
                Email = Email,
                Password = Password,
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
