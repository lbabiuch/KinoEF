using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Configurations
{
    class SalaConfiguration : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.IdSali);
            builder.HasOne(x => x.Kino).WithMany(x => x.Sale);
        }

    }
}
