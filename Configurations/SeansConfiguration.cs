using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF.Configurations
{
    class SeansConfiguration : IEntityTypeConfiguration<Seans>
    {
        public void Configure(EntityTypeBuilder<Seans> builder)
        {
            builder.ToTable("Seanse");
            builder.HasKey(x => x.IdSeansu);
        }
    }
}
