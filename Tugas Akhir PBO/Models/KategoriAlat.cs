using System;
using System.Collections.Generic;

namespace Tugas_Akhir_PBO.Models;

public partial class KategoriAlat
{
    public string IdKategori { get; set; } = null!;

    public string? NamaKategori { get; set; }

    public string? Deskripsi { get; set; }

    public virtual ICollection<Alat> Alats { get; set; } = new List<Alat>();

    public List<KategoriAlat> GetKategori()
    {
        using (var db = new TugasAkhirPboContext())
        {
      
            return db.KategoriAlats.ToList();
        }
    }
}
