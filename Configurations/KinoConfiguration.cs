using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Configurations
{
    class KinoConfiguration : IEntityTypeConfiguration<Kino>
    {
        public void Configure(EntityTypeBuilder<Kino> builder)
        {
            builder.ToTable("Kina");
            builder.HasKey(x => x.Id);
        }
    }
}
