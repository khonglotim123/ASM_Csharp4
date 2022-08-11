using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class HoaDonChiTietConfigguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(c => new {c.IdChiTietSP,c.IdHoaDon });
            builder.HasOne<ChiTietSP>(c => c.chiTietSP).WithMany(c => c.HoaDonChiTiets).HasForeignKey(c => c.IdChiTietSP);
            builder.HasOne<HoaDon>(c => c.hoaDon).WithMany(c => c.HoaDonChiTiets).HasForeignKey(c => c.IdHoaDon);
        }
    }
}
