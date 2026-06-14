using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tugas_Akhir_PBO.Models;

public partial class Admin : Abstract_User
{
    public int Id { get; set; }

    public string? Nama { get; set; }

    public string? Alamat { get; set; }

    public string? Kontak { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public override void insert()
    {
        using (var db = new TugasAkhirPboContext())
        {
            db.Admins.Add(this);
        }
    }
    public Admin getAdmin(int id)
    {
        using (var db = new TugasAkhirPboContext())
        {
            Admin user = db.Admins.Find(id);
            return user;
        }
    }
}
