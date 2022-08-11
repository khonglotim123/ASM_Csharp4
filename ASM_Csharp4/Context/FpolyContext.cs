using ASM_Csharp4.Configgurations;
using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Context
{
    public class FpolyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-QQT9QHE\\SQLEXPRESS;Initial Catalog=ASMC#4;User ID=xagaph13499;Password=x02022002");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietSPConfiguration());
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new CuaHangConfiguration());
            modelBuilder.ApplyConfiguration(new DongSPConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new GioHangConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfigguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new MauSacConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new NSXConfiguration());

        }

        public DbSet<ChiTietSP> chiTietSPs { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<CuaHang> cuaHangs { get; set; }
        public DbSet<DongSP> dongSPs { get; set; }
        public DbSet<GioHang> gioHangs { get; set; }
        public DbSet<GioHangChiTiet> gioHangChiTiets { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<NSX> nSXes { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }


    }
}
