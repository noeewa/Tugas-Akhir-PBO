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
                var detail = db.Peminjamen
                    .Include(p => p.IdUserNavigation)
                    .Where(p => p.IdPeminjaman == idPeminjaman)
                    .Select(p => new
                    {
                        p.IdPeminjaman,
                        NamaUser = p.IdUserNavigation != null ? p.IdUserNavigation.Nama : "",
                        p.TanggalPeminjaman,
                        p.TanggalKembali,
                        p.DetailPeminjaman
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
