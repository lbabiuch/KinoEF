using KinoEF.Configurations;
using KinoEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoEF
{
    class KinoContext : DbContext
    {
        public DbSet<Kino> Kina;
        public DbSet<Sala> Sale;
        public DbSet<Miejsce> Miejsca;
        public DbSet<Bilet> Bilety;
        public DbSet<Seans> Seanse;

        public static readonly ILoggerFactory Logger = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=DESKTOP-2F2GHDH\\SQLEXPRESS;Initial Catalog=Kino;Integrated Security=True")
                .UseLoggerFactory(Logger);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
