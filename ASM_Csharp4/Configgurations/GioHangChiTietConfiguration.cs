using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class GioHangChiTietConfiguration : IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.ToTable("GioHangChiTiet");
            builder.HasKey(c => new {c.IdChiTietSP,c.IdGioHang });
            builder.HasOne<GioHang>(c => c.gioHang).WithMany(c => c.GioHangChiTiets).HasForeignKey(c => c.IdGioHang);
            builder.HasOne<ChiTietSP>(c => c.chiTietSP).WithMany(c => c.GioHangChiTiets).HasForeignKey(c => c.IdChiTietSP);
        }
    }
}
