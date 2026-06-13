using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tugas_Akhir_PBO.Models;

public partial class TugasAkhirPboContext : DbContext
{
    public TugasAkhirPboContext()
    {
    }

    public TugasAkhirPboContext(DbContextOptions<TugasAkhirPboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }
    public virtual DbSet<Alat> Alats { get; set; }
    public virtual DbSet<DetailPeminjaman> DetailPeminjamen { get; set; }
    public virtual DbSet<Jadwal> Jadwals { get; set; }
    public virtual DbSet<KategoriAlat> KategoriAlats { get; set; }
    public virtual DbSet<Mitra> Mitras { get; set; }
    public virtual DbSet<Peminjam> Peminjams { get; set; }
    public virtual DbSet<Peminjaman> Peminjamen { get; set; }
    public virtual DbSet<Pengembalian> Pengembalians { get; set; }
    public virtual DbSet<Riwayat> Riwayats { get; set; }
    public virtual DbSet<Status> Statuses { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tugas_akhir_pbo;Username=postgres;Password=basda123;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("Admin_pkey");
            entity.ToTable("admins");
            entity.Property(e => e.IdAdmin).HasColumnName("id_admin"); // Perbaikan: id_admin (lowercase)
        });

        modelBuilder.Entity<Alat>(entity =>
        {
            entity.HasKey(e => e.IdAlat).HasName("alat_pkey");
            entity.ToTable("alat");

            entity.Property(e => e.IdAlat).HasColumnName("id_alat"); // SERIAL = int, jangan pakai HasMaxLength
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.IdMitra).HasColumnName("id_mitra");
            entity.Property(e => e.Kategori).HasMaxLength(50).HasColumnName("kategori");
            entity.Property(e => e.Kondisi).HasMaxLength(50).HasColumnName("kondisi");
            entity.Property(e => e.NamaAlat).HasMaxLength(150).HasColumnName("nama_alat");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdMitraNavigation).WithMany(p => p.Alats)
                .HasForeignKey(d => d.IdMitra)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("alat_id_mitra_fkey");

            entity.HasOne(d => d.KategoriNavigation).WithMany(p => p.Alats)
                .HasForeignKey(d => d.Kategori)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("alat_kategori_fkey");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Alats)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("alat_status_fkey");
        });

        modelBuilder.Entity<DetailPeminjaman>(entity =>
        {
            // Perbaikan: Mendaftarkan Composite Primary Key sesuai SQL Baru
            entity.HasKey(e => new { e.IdJadwal, e.IdPeminjaman }).HasName("detail_peminjaman_pkey");
            entity.ToTable("detail_peminjaman");

            entity.Property(e => e.IdJadwal).HasMaxLength(50).HasColumnName("id_jadwal");
            entity.Property(e => e.IdPeminjaman).HasMaxLength(50).HasColumnName("id_peminjaman");
            entity.Property(e => e.IdAlat).HasColumnName("id_alat");

            entity.HasOne(d => d.IdJadwalNavigation).WithMany()
                .HasForeignKey(d => d.IdJadwal)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("detail_peminjaman_id_jadwal_fkey");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithMany()
                .HasForeignKey(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("detail_peminjaman_id_peminjaman_fkey");
        });

        modelBuilder.Entity<Jadwal>(entity =>
        {
            entity.HasKey(e => e.IdJadwal).HasName("jadwal_pkey");
            entity.ToTable("jadwal");
            entity.HasIndex(e => e.IdAlat, "jadwal_id_alat_key").IsUnique();

            entity.Property(e => e.IdJadwal).HasMaxLength(50).HasColumnName("id_jadwal");
            entity.Property(e => e.IdAlat).HasColumnName("id_alat"); // Perbaikan: Dihapus HasMaxLength karena bertipe INTEGER
            entity.Property(e => e.IdPeminjaman).HasMaxLength(50).HasColumnName("id_peminjaman");
            entity.Property(e => e.StatusJadwal).HasMaxLength(50).HasColumnName("status_jadwal");
            entity.Property(e => e.TanggalMulai).HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai).HasColumnName("tanggal_selesai");

            entity.HasOne(d => d.IdAlatNavigation).WithOne(p => p.Jadwal)
                .HasForeignKey<Jadwal>(d => d.IdAlat)
                .OnDelete(DeleteBehavior.Cascade) // Mengubah ClientSetNull -> Cascade
                .HasConstraintName("jadwal_id_alat_fkey");
        });

        modelBuilder.Entity<KategoriAlat>(entity =>
        {
            entity.HasKey(e => e.IdKategori).HasName("kategori_alat_pkey"); // Perbaikan spasi nama key
            entity.ToTable("kategori_alat"); // Perbaikan nama tabel spasi jadi snake_case

            entity.Property(e => e.IdKategori).HasMaxLength(50).HasColumnName("id_kategori");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.NamaKategori).HasMaxLength(100).HasColumnName("nama_kategori");
        });

        modelBuilder.Entity<Mitra>(entity =>
        {
            entity.HasKey(e => e.IdMitra).HasName("Mitra_pkey");
            entity.ToTable("mitra");

            entity.Property(e => e.IdMitra).HasColumnName("id_mitra");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.JenisMitra).HasMaxLength(50).HasColumnName("jenis_mitra");
            entity.Property(e => e.Kontak).HasMaxLength(20).HasColumnName("kontak");
            entity.Property(e => e.NamaMitra).HasMaxLength(150).HasColumnName("nama_mitra");
        });

        modelBuilder.Entity<Peminjam>(entity =>
        {
            entity.HasKey(e => e.IdPeminjam).HasName("peminjam_pkey");
            entity.ToTable("peminjam");

            entity.Property(e => e.IdPeminjam).HasColumnName("id_peminjam");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
        });

        modelBuilder.Entity<Peminjaman>(entity =>
        {
            entity.HasKey(e => e.IdPeminjaman).HasName("peminjaman_pkey");
            entity.ToTable("peminjaman");

            entity.Property(e => e.IdPeminjaman).HasMaxLength(50).HasColumnName("id_peminjaman");
            entity.Property(e => e.DetailPeminjaman).HasColumnName("detail_peminjaman");
            entity.Property(e => e.IdUser).HasMaxLength(50).HasColumnName("id_user");
            entity.Property(e => e.TanggalKembali).HasMaxLength(20).HasColumnName("tanggal_kembali");
            entity.Property(e => e.TanggalPeminjaman).HasMaxLength(20).HasColumnName("tanggal_peminjaman");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Peminjamen)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("peminjaman_id_user_fkey");
        });

        modelBuilder.Entity<Pengembalian>(entity =>
        {
            entity.HasKey(e => e.IdPengembalian).HasName("pengembalian_pkey");
            entity.ToTable("pengembalian");
            entity.HasIndex(e => e.IdPeminjaman, "pengembalian_id_peminjaman_key").IsUnique();

            entity.Property(e => e.IdPengembalian).HasMaxLength(50).HasColumnName("id_pengembalian");
            entity.Property(e => e.Denda).HasMaxLength(50).HasColumnName("denda");
            entity.Property(e => e.IdPeminjaman).HasMaxLength(50).HasColumnName("id_peminjaman");
            entity.Property(e => e.KondisiAlat).HasMaxLength(50).HasColumnName("kondisi_alat");
            entity.Property(e => e.TanggalPengembalian).HasColumnName("tanggal_pengembalian");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithOne(p => p.Pengembalian)
                .HasForeignKey<Pengembalian>(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade) // Mengubah ClientSetNull -> Cascade
                .HasConstraintName("pengembalian_id_peminjaman_fkey");
        });

        modelBuilder.Entity<Riwayat>(entity =>
        {
            entity.HasKey(e => e.IdRiwayat).HasName("Riwayat_pkey");
            entity.ToTable("riwayat"); // Perbaikan kapitalisasi: Riwayat -> riwayat

            entity.Property(e => e.IdRiwayat).HasMaxLength(50).HasColumnName("id_riwayat");
            entity.Property(e => e.IdPeminjaman).HasMaxLength(50).HasColumnName("id_peminjaman");
            entity.Property(e => e.IdPengembalian).HasMaxLength(50).HasColumnName("id_pengembalian");
            entity.Property(e => e.IdUser).HasMaxLength(50).HasColumnName("id_user");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade) // Mengubah ClientSetNull -> Cascade
                .HasConstraintName("Riwayat_id_peminjaman_fkey");

            entity.HasOne(d => d.IdPengembalianNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdPengembalian)
                .OnDelete(DeleteBehavior.Cascade) // Mengubah ClientSetNull -> Cascade
                .HasConstraintName("Riwayat_id_pengembalian_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade) // Mengubah ClientSetNull -> Cascade
                .HasConstraintName("Riwayat_id_user_fkey");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("status_pkey");
            entity.ToTable("status");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.Status1).HasMaxLength(50).HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("user_pkey");
            entity.ToTable("users");

            entity.Property(e => e.IdUser).HasMaxLength(50).HasColumnName("id_user");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
            entity.Property(e => e.Email).HasMaxLength(150).HasColumnName("email");
            entity.Property(e => e.IdAdmin).HasColumnName("id_admin");
            entity.Property(e => e.IdMitra).HasColumnName("id_mitra");
            entity.Property(e => e.IdPeminjam).HasColumnName("id_peminjam");
            entity.Property(e => e.Nama).HasMaxLength(100).HasColumnName("nama");
            entity.Property(e => e.NoHp).HasMaxLength(20).HasColumnName("no_hp");
            entity.Property(e => e.Password).HasMaxLength(255).HasColumnName("password");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdAdmin)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("user_id_admin_fkey");

            entity.HasOne(d => d.IdMitraNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdMitra)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("user_id_mitra_fkey");

            entity.HasOne(d => d.IdPeminjamNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdPeminjam)
                .OnDelete(DeleteBehavior.Cascade) // SINKRONISASI CASCADE
                .HasConstraintName("user_id_peminjam_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}