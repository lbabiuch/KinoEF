using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Configurations
{
    class BiletConfiguration : IEntityTypeConfiguration<Bilet>
    {
        public void Configure(EntityTypeBuilder<Bilet> builder)
        {
            builder.ToTable("Bilety");
            builder.HasKey(x => x.IdBiletu);
            builder.HasOne(x => x.Miejsce).WithMany(x => x.Bilety);
            builder.HasOne(x => x.Seans).WithMany(x => x.Bilety);
        }
    }
}
