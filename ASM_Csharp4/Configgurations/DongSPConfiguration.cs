using CodeFirst_13Bang.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_Csharp4.Configgurations
{
    class DongSPConfiguration : IEntityTypeConfiguration<DongSP>
    {
        public void Configure(EntityTypeBuilder<DongSP> builder)
        {
            builder.ToTable("DongSP");
            builder.HasKey(c => c.Id);
        }
    }
}
