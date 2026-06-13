using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string? Status1 { get; set; }

    public virtual ICollection<Alat> Alats { get; set; } = new List<Alat>();
}
