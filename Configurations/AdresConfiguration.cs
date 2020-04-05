using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace KinoEF.Configurations
{
    class AdresConfiguration : IEntityTypeConfiguration<Adres>
    {
        public void Configure(EntityTypeBuilder<Adres> builder)
        {
            builder.ToTable("Adresy");
            builder.HasKey(x => x.IdKina);
            builder.HasOne(x => x.Kino).WithOne(x => x.Adres).HasForeignKey<Kino>(x => x.Id);
        }
    }
}
