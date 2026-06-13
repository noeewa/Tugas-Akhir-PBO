using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string? NamaAdmin { get; set; }

    public string? Alamat { get; set; }

    public string? Kontak { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
