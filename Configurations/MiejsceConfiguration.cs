using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Configurations
{
    class MiejsceConfiguration : IEntityTypeConfiguration<Miejsce>
    {
        public void Configure(EntityTypeBuilder<Miejsce> builder)
        {
            builder.ToTable("Miejsca");
            builder.HasKey(x => x.IdMiejsca);
            builder.HasOne(x => x.Sala).WithMany(x => x.Miejsca);
        }
    }
}
