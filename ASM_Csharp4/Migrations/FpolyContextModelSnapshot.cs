﻿// <auto-generated />
using System;
using ASM_Csharp4.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASM_Csharp4.Migrations
{
    [DbContext(typeof(FpolyContext))]
    partial class FpolyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst_13Bang.Models.ChiTietSP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<int>("GiaNhap")
                        .HasColumnType("int");

                    b.Property<int>("IdDongSP")
                        .HasColumnType("int");

                    b.Property<int>("IdMauSac")
                        .HasColumnType("int");

                    b.Property<int>("IdNsx")
                        .HasColumnType("int");

                    b.Property<int>("IdSP")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamBH")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDongSP");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSP");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.ChucVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.CuaHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuocGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhPho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CuaHang");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.DongSP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DongSP");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.GioHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdKH")
                        .HasColumnType("int");

                    b.Property<int>("IdNV")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKH");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.GioHangChiTiet", b =>
                {
                    b.Property<int>("IdChiTietSP")
                        .HasColumnType("int");

                    b.Property<int>("IdGioHang")
                        .HasColumnType("int");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("DonGiaKhiGiam")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdChiTietSP", "IdGioHang");

                    b.HasIndex("IdGioHang");

                    b.ToTable("GioHangChiTiet");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdKH")
                        .HasColumnType("int");

                    b.Property<int>("IdNV")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayNhan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayShip")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdKH");

                    b.HasIndex("IdNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.HoaDonChiTiet", b =>
                {
                    b.Property<int>("IdChiTietSP")
                        .HasColumnType("int");

                    b.Property<int>("IdHoaDon")
                        .HasColumnType("int");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdChiTietSP", "IdHoaDon");

                    b.HasIndex("IdHoaDon");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuocGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhPho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.MauSac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MauSac");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.NSX", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NSX");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCH")
                        .HasColumnType("int");

                    b.Property<int>("IdCV")
                        .HasColumnType("int");

                    b.Property<int>("IdGuiBc")
                        .HasColumnType("int");

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<int?>("nhanVienId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCH");

                    b.HasIndex("IdCV");

                    b.HasIndex("nhanVienId");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.ChiTietSP", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.DongSP", "dongSP")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IdDongSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.MauSac", "mauSac")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.NSX", "nSX")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IdNsx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.SanPham", "sanPham")
                        .WithMany("chiTietSPs")
                        .HasForeignKey("IdSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dongSP");

                    b.Navigation("mauSac");

                    b.Navigation("nSX");

                    b.Navigation("sanPham");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.GioHang", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.KhachHang", "khachHang")
                        .WithMany("gioHangs")
                        .HasForeignKey("IdKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHang");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.ChiTietSP", "chiTietSP")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdChiTietSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.GioHang", "gioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chiTietSP");

                    b.Navigation("gioHang");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.HoaDon", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.KhachHang", "khachHang")
                        .WithMany("hoaDons")
                        .HasForeignKey("IdKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.NhanVien", "nhanVien")
                        .WithMany("hoaDons")
                        .HasForeignKey("IdNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.ChiTietSP", "chiTietSP")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.HoaDon", "hoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chiTietSP");

                    b.Navigation("hoaDon");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.NhanVien", b =>
                {
                    b.HasOne("CodeFirst_13Bang.Models.CuaHang", "cuaHang")
                        .WithMany("nhanViens")
                        .HasForeignKey("IdCH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.ChucVu", "chucVu")
                        .WithMany("nhanViens")
                        .HasForeignKey("IdCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst_13Bang.Models.NhanVien", "nhanVien")
                        .WithMany("nhanViens")
                        .HasForeignKey("nhanVienId");

                    b.Navigation("chucVu");

                    b.Navigation("cuaHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.ChiTietSP", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.ChucVu", b =>
                {
                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.CuaHang", b =>
                {
                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.DongSP", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.KhachHang", b =>
                {
                    b.Navigation("gioHangs");

                    b.Navigation("hoaDons");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.MauSac", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.NSX", b =>
                {
                    b.Navigation("chiTietSPs");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.NhanVien", b =>
                {
                    b.Navigation("hoaDons");

                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("CodeFirst_13Bang.Models.SanPham", b =>
                {
                    b.Navigation("chiTietSPs");
                });
#pragma warning restore 612, 618
        }
    }
}