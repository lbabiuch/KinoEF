﻿// <auto-generated />
using System;
using KinoEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KinoEF.Migrations
{
    [DbContext(typeof(KinoContext))]
    partial class KinoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KinoEF.Models.Adres", b =>
                {
                    b.Property<int>("IdKina")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miasto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numer")
                        .HasColumnType("int");

                    b.Property<string>("NumerTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKina");

                    b.ToTable("Adresy");
                });

            modelBuilder.Entity("KinoEF.Models.Bilet", b =>
                {
                    b.Property<int>("IdBiletu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<int?>("MiejsceIdMiejsca")
                        .HasColumnType("int");

                    b.Property<int?>("SeansIdSeansu")
                        .HasColumnType("int");

                    b.HasKey("IdBiletu");

                    b.HasIndex("MiejsceIdMiejsca");

                    b.HasIndex("SeansIdSeansu");

                    b.ToTable("Bilety");
                });

            modelBuilder.Entity("KinoEF.Models.Kino", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NazwaKina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kina");
                });

            modelBuilder.Entity("KinoEF.Models.Miejsce", b =>
                {
                    b.Property<int>("IdMiejsca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numer")
                        .HasColumnType("int");

                    b.Property<int>("Rzad")
                        .HasColumnType("int");

                    b.Property<int?>("SalaIdSali")
                        .HasColumnType("int");

                    b.HasKey("IdMiejsca");

                    b.HasIndex("SalaIdSali");

                    b.ToTable("Miejsca");
                });

            modelBuilder.Entity("KinoEF.Models.Sala", b =>
                {
                    b.Property<int>("IdSali")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KinoId")
                        .HasColumnType("int");

                    b.Property<int>("LiczbaMiejsc")
                        .HasColumnType("int");

                    b.Property<string>("NazwaSali")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSali");

                    b.HasIndex("KinoId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("KinoEF.Models.Seans", b =>
                {
                    b.Property<int>("IdSeansu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Godzina")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazwaSeansu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSeansu");

                    b.ToTable("Seanse");
                });

            modelBuilder.Entity("KinoEF.Models.Bilet", b =>
                {
                    b.HasOne("KinoEF.Models.Miejsce", "Miejsce")
                        .WithMany("Bilety")
                        .HasForeignKey("MiejsceIdMiejsca");

                    b.HasOne("KinoEF.Models.Seans", "Seans")
                        .WithMany("Bilety")
                        .HasForeignKey("SeansIdSeansu");
                });

            modelBuilder.Entity("KinoEF.Models.Kino", b =>
                {
                    b.HasOne("KinoEF.Models.Adres", "Adres")
                        .WithOne("Kino")
                        .HasForeignKey("KinoEF.Models.Kino", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KinoEF.Models.Miejsce", b =>
                {
                    b.HasOne("KinoEF.Models.Sala", "Sala")
                        .WithMany("Miejsca")
                        .HasForeignKey("SalaIdSali");
                });

            modelBuilder.Entity("KinoEF.Models.Sala", b =>
                {
                    b.HasOne("KinoEF.Models.Kino", "Kino")
                        .WithMany("Sale")
                        .HasForeignKey("KinoId");
                });
#pragma warning restore 612, 618
        }
    }
}
