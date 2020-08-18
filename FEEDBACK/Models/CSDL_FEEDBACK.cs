namespace FEEDBACK.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CSDL_FEEDBACK : DbContext
    {
        public CSDL_FEEDBACK()
            : base("name=CSDL_FEEDBACK")
        {
        }

        public virtual DbSet<CAUHOI> CAUHOIs { get; set; }
        public virtual DbSet<CAUTRALOI> CAUTRALOIs { get; set; }
        public virtual DbSet<CHITIETPHANHOI> CHITIETPHANHOIs { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<DANHGIA> DANHGIAs { get; set; }
        public virtual DbSet<DM_KHACHSAN> DM_KHACHSAN { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAICAUHOI> LOAICAUHOIs { get; set; }
        public virtual DbSet<LOAIKHACHSAN> LOAIKHACHSANs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAUHOI>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<CAUHOI>()
                .HasMany(e => e.CAUTRALOIs)
                .WithRequired(e => e.CAUHOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAUHOI>()
                .HasMany(e => e.CHITIETPHANHOIs)
                .WithRequired(e => e.CAUHOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .HasMany(e => e.CAUHOIs)
                .WithRequired(e => e.DANGNHAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANHGIA>()
                .HasMany(e => e.CHITIETPHANHOIs)
                .WithRequired(e => e.DANHGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DM_KHACHSAN>()
                .HasMany(e => e.CHITIETPHANHOIs)
                .WithRequired(e => e.DM_KHACHSAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.CAUTRALOIs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.CHITIETPHANHOIs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIKHACHSAN>()
                .Property(e => e.GHICHU)
                .IsFixedLength();

            modelBuilder.Entity<LOAIKHACHSAN>()
                .HasMany(e => e.DM_KHACHSAN)
                .WithRequired(e => e.LOAIKHACHSAN)
                .WillCascadeOnDelete(false);
        }
    }
}
