using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(c => c.Id);            
            builder.HasOne<ChucVu>(c => c.chucVu).WithMany(c => c.nhanViens).HasForeignKey(c => c.IdCV);
            builder.HasOne<CuaHang>(c => c.cuaHang).WithMany(c => c.nhanViens).HasForeignKey(c => c.IdCH);

        }
    }
}
