using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBANHANG.Models
{
    public partial class ContextGiayDB : DbContext
    {
        public ContextGiayDB()
            : base("name=ContextGiayDB")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblCTHD> tblCTHDs { get; set; }
        public virtual DbSet<tblGiay> tblGiays { get; set; }
        public virtual DbSet<tblHDBan> tblHDBans { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblTaiKhoan> tblTaiKhoans { get; set; }
        public virtual DbSet<tblThuongHieu> tblThuongHieux { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblGiay>()
                .HasMany(e => e.tblCTHDs)
                .WithRequired(e => e.tblGiay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblHDBan>()
                .HasMany(e => e.tblCTHDs)
                .WithRequired(e => e.tblHDBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKhachHang>()
                .HasMany(e => e.tblHDBans)
                .WithRequired(e => e.tblKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNhanVien>()
                .HasMany(e => e.tblHDBans)
                .WithRequired(e => e.tblNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaiKhoan>()
                .HasMany(e => e.tblNhanViens)
                .WithRequired(e => e.tblTaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblThuongHieu>()
                .HasMany(e => e.tblGiays)
                .WithRequired(e => e.tblThuongHieu)
                .WillCascadeOnDelete(false);
        }
    }
}
