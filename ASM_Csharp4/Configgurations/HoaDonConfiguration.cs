using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(c => c.Id);
            builder.HasOne<NhanVien>(c => c.nhanVien).WithMany(c => c.hoaDons).HasForeignKey(c => c.IdNV);
            builder.HasOne<KhachHang>(c => c.khachHang).WithMany(c => c.hoaDons).HasForeignKey(c => c.IdKH);
        }
    }
}
