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

    public virtual DbSet<Jadwal> Jadwals { get; set; }

    public virtual DbSet<KategoriAlat> KategoriAlats { get; set; }

    public virtual DbSet<Mitra> Mitras { get; set; }

    public virtual DbSet<Peminjam> Peminjams { get; set; }

    public virtual DbSet<Peminjaman> Peminjamen { get; set; }

    public virtual DbSet<Pengembalian> Pengembalians { get; set; }

    public virtual DbSet<Riwayat> Riwayats { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tugas_akhir_pbo;Username=postgres;Password=basda123;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("admins_pkey");

            entity.ToTable("admins");

            entity.Property(e => e.Id).HasColumnName("id_admin");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
            entity.Property(e => e.Kontak)
                .HasMaxLength(20)
                .HasColumnName("kontak");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .HasColumnName("nama_admin");
        });

        modelBuilder.Entity<Alat>(entity =>
        {
            entity.HasKey(e => e.IdAlat).HasName("alat_pkey");

            entity.ToTable("alat");

            entity.Property(e => e.IdAlat).HasColumnName("id_alat");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.IdMitra).HasColumnName("id_mitra");
            entity.Property(e => e.Kategori)
                .HasMaxLength(50)
                .HasColumnName("kategori");
            entity.Property(e => e.Kondisi)
                .HasMaxLength(50)
                .HasColumnName("kondisi");
            entity.Property(e => e.NamaAlat)
                .HasMaxLength(150)
                .HasColumnName("nama_alat");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasColumnName("status");

            entity.HasOne(d => d.IdMitraNavigation).WithMany(p => p.Alats)
                .HasForeignKey(d => d.IdMitra)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_alat_mitra");

            entity.HasOne(d => d.KategoriNavigation).WithMany(p => p.Alats)
                .HasForeignKey(d => d.Kategori)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_alat_kategori");
        });

        modelBuilder.Entity<Jadwal>(entity =>
        {
            entity.HasKey(e => e.IdJadwal).HasName("jadwal_pkey");

            entity.ToTable("jadwal");

            entity.Property(e => e.IdJadwal)
                .HasMaxLength(50)
                .HasColumnName("id_jadwal");
            entity.Property(e => e.IdAlat).HasColumnName("id_alat");
            entity.Property(e => e.IdPeminjaman)
                .HasMaxLength(50)
                .HasColumnName("id_peminjaman");
            entity.Property(e => e.StatusJadwal)
                .HasMaxLength(50)
                .HasColumnName("status_jadwal");
            entity.Property(e => e.TanggalMulai).HasColumnName("tanggal_mulai");
            entity.Property(e => e.TanggalSelesai).HasColumnName("tanggal_selesai");

            entity.HasOne(d => d.IdAlatNavigation).WithMany(p => p.Jadwals)
                .HasForeignKey(d => d.IdAlat)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_jadwal_alat");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithMany(p => p.Jadwals)
                .HasForeignKey(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_jadwal_peminjaman");
        });

        modelBuilder.Entity<KategoriAlat>(entity =>
        {
            entity.HasKey(e => e.IdKategori).HasName("kategori_alat_pkey");

            entity.ToTable("kategori_alat");

            entity.Property(e => e.IdKategori)
                .HasMaxLength(50)
                .HasColumnName("id_kategori");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.NamaKategori)
                .HasMaxLength(100)
                .HasColumnName("nama_kategori");
        });

        modelBuilder.Entity<Mitra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mitra_pkey");

            entity.ToTable("mitra");

            entity.Property(e => e.Id).HasColumnName("id_mitra");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
            entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");
            entity.Property(e => e.JenisMitra)
                .HasMaxLength(50)
                .HasColumnName("jenis_mitra");
            entity.Property(e => e.Kontak)
                .HasMaxLength(20)
                .HasColumnName("kontak");
            entity.Property(e => e.Nama)
                .HasMaxLength(150)
                .HasColumnName("nama_mitra");
        });

        modelBuilder.Entity<Peminjam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("peminjam_pkey");

            entity.ToTable("peminjam");

            entity.Property(e => e.Id).HasColumnName("id_peminjam");
            entity.Property(e => e.Alamat).HasColumnName("alamat");
            entity.Property(e => e.Kontak)
                .HasMaxLength(20)
                .HasColumnName("kontak");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .HasColumnName("nama_peminjam");
        });

        modelBuilder.Entity<Peminjaman>(entity =>
        {
            entity.HasKey(e => e.IdPeminjaman).HasName("peminjaman_pkey");

            entity.ToTable("peminjaman");

            entity.Property(e => e.IdPeminjaman)
                .HasMaxLength(50)
                .HasColumnName("id_peminjaman");
            entity.Property(e => e.DetailPeminjaman).HasColumnName("detail_peminjaman");
            entity.Property(e => e.IdUser)
                .HasMaxLength(50)
                .HasColumnName("id_user");
            entity.Property(e => e.TanggalKembali)
                .HasMaxLength(20)
                .HasColumnName("tanggal_kembali");
            entity.Property(e => e.TanggalPeminjaman)
                .HasMaxLength(20)
                .HasColumnName("tanggal_peminjaman");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Peminjamen)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_peminjaman_user");
        });

        modelBuilder.Entity<Pengembalian>(entity =>
        {
            entity.HasKey(e => e.IdPengembalian).HasName("pengembalian_pkey");

            entity.ToTable("pengembalian");

            entity.HasIndex(e => e.IdPeminjaman, "pengembalian_id_peminjaman_key").IsUnique();

            entity.Property(e => e.IdPengembalian)
                .HasMaxLength(50)
                .HasColumnName("id_pengembalian");
            entity.Property(e => e.Denda)
                .HasMaxLength(50)
                .HasColumnName("denda");
            entity.Property(e => e.IdPeminjaman)
                .HasMaxLength(50)
                .HasColumnName("id_peminjaman");
            entity.Property(e => e.KondisiAlat)
                .HasMaxLength(50)
                .HasColumnName("kondisi_alat");
            entity.Property(e => e.TanggalPengembalian).HasColumnName("tanggal_pengembalian");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithOne(p => p.Pengembalian)
                .HasForeignKey<Pengembalian>(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_pengembalian_peminjaman");
        });

        modelBuilder.Entity<Riwayat>(entity =>
        {
            entity.HasKey(e => e.IdRiwayat).HasName("riwayat_pkey");

            entity.ToTable("riwayat");

            entity.Property(e => e.IdRiwayat)
                .HasMaxLength(50)
                .HasColumnName("id_riwayat");
            entity.Property(e => e.IdPeminjaman)
                .HasMaxLength(50)
                .HasColumnName("id_peminjaman");
            entity.Property(e => e.IdPengembalian)
                .HasMaxLength(50)
                .HasColumnName("id_pengembalian");
            entity.Property(e => e.IdUser)
                .HasMaxLength(50)
                .HasColumnName("id_user");

            entity.HasOne(d => d.IdPeminjamanNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdPeminjaman)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_riwayat_peminjaman");

            entity.HasOne(d => d.IdPengembalianNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdPengembalian)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_riwayat_pengembalian");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Riwayats)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_riwayat_user");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("id_user");
            entity.Property(e => e.Emails)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Id).HasColumnName("id_admin");
            entity.Property(e => e.Id).HasColumnName("id_mitra");
            entity.Property(e => e.Id).HasColumnName("id_peminjam");
            entity.Property(e => e.Pass)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .HasColumnName("username");

            entity.HasOne(d => d.IdAdminNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_users_admin");

            entity.HasOne(d => d.IdMitraNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_users_mitra");

            entity.HasOne(d => d.IdPeminjamNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_users_peminjam");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
