using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Tugas_Akhir_PBO.Models;

namespace Tugas_Akhir_PBO.VIEW
{
    public partial class DsbDetailPeminjaman : Form
    {
        private string idPeminjaman { get; set; }

        public DsbDetailPeminjaman(string idPeminjaman)
        {
            InitializeComponent();
            this.idPeminjaman = idPeminjaman;
            DataGridDetail.AutoGenerateColumns = true;
        }

        private void DsbDetailPeminjaman_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idPeminjaman))
            {
                loadDetail();
            }
        }

        private void loadDetail()
        {
            if (string.IsNullOrEmpty(idPeminjaman))
                return;

            using (var db = new TugasAkhirPboContext())
            {
                var detail = db.Jadwals
                    .Include(j => j.IdPeminjamanNavigation)
                        .ThenInclude(p => p.IdUserNavigation)
                    .Include(j => j.IdAlatNavigation)
                    .Where(j => j.IdPeminjaman == idPeminjaman)
                    .Select(j => new
                    {
                        j.IdPeminjaman,
                        NamaUser = j.IdPeminjamanNavigation != null && j.IdPeminjamanNavigation.IdUserNavigation != null
                            ? j.IdPeminjamanNavigation.IdUserNavigation.Nama
                            : "",
                        j.IdPeminjamanNavigation.TanggalPeminjaman,
                        j.IdPeminjamanNavigation.TanggalKembali,
                        j.IdAlatNavigation.NamaAlat,
                        TanggalMulai = j.TanggalMulai,
                        TanggalSelesai = j.TanggalSelesai
                    })
                    .ToList();

                DataGridDetail.DataSource = detail;
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            loadDetail();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
