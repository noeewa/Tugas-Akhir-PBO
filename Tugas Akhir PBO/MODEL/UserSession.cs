using System;
using System.Collections.Generic;
using System.Text;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.MODEL
{
    public static class UserSession
    {
        // Semua properti bersifat static agar nilainya menetap di memori aplikasi
        public static string UserId { get; set; }
        public static string Username { get; set; }
        public static int? IdAdmin { get; set; }
        public static int? IdMitra { get; set; }
        public static int? IdPeminjam { get; set; }


        // Fungsi untuk membersihkan sesi saat logout
        public static void Clear()
        {
            UserId = null;
            Username = null;
            IdAdmin = -1;
            IdMitra = -1;
            IdPeminjam = -1;
        }
    }
}
