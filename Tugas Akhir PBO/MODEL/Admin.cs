using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string? Alamat { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public Admin getAdmin(int id_admin)
    {
        using (var db = new TugasAkhirPboContext())
        {
            return db.Admins.FirstOrDefault(u => u.IdAdmin == id_admin);
        }
    }
}
