using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class ChiTietSPConfiguration : IEntityTypeConfiguration<ChiTietSP>
    {
        public void Configure(EntityTypeBuilder<ChiTietSP> builder)
        {
            builder.ToTable("ChiTietSP");
            builder.HasKey(c => c.Id);
            builder.HasOne<NSX>(c => c.nSX).WithMany(c => c.chiTietSPs).HasForeignKey(c => c.IdNsx);
            builder.HasOne<MauSac>(c => c.mauSac).WithMany(c => c.chiTietSPs).HasForeignKey(c => c.IdMauSac);
            builder.HasOne<SanPham>(c => c.sanPham).WithMany(c => c.chiTietSPs).HasForeignKey(c => c.IdSP);
            builder.HasOne<DongSP>(c => c.dongSP).WithMany(c => c.chiTietSPs).HasForeignKey(c => c.IdDongSP);
        }
    }
}
