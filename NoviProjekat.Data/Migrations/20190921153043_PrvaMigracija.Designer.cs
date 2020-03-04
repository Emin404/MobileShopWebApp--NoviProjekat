﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoviProjekat.Data;

namespace NoviProjekat.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20190921153043_PrvaMigracija")]
    partial class PrvaMigracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Artikal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena");

                    b.Property<int?>("ModelId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<int?>("SkladisteId");

                    b.Property<int>("StanjeNaSkladistu");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Artikal");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KantonId");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("KantonId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Kanton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Kanton");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Klijent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("KorisnickiNalogId");

                    b.Property<int?>("OsobaId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.HasIndex("OsobaId");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Lozinka");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.Property<int>("ProizvodjacId");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodjacId");

                    b.ToTable("Modeli");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Osobe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojTelefona");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<int>("GradId");

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<int?>("SpolId");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("SpolId");

                    b.ToTable("Osobe");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Proizvodjac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Proizvodjac");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Skladiste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Skladiste");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Artikal", b =>
                {
                    b.HasOne("NoviProjekat.Data.EntityModels.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("NoviProjekat.Data.EntityModels.Skladiste", "Skladiste")
                        .WithMany()
                        .HasForeignKey("SkladisteId");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Grad", b =>
                {
                    b.HasOne("NoviProjekat.Data.EntityModels.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonId");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Klijent", b =>
                {
                    b.HasOne("NoviProjekat.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");

                    b.HasOne("NoviProjekat.Data.EntityModels.Osobe", "Osoba")
                        .WithMany()
                        .HasForeignKey("OsobaId");
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Model", b =>
                {
                    b.HasOne("NoviProjekat.Data.EntityModels.Proizvodjac", "Proizvodjac")
                        .WithMany()
                        .HasForeignKey("ProizvodjacId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NoviProjekat.Data.EntityModels.Osobe", b =>
                {
                    b.HasOne("NoviProjekat.Data.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NoviProjekat.Data.EntityModels.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolId");
                });
#pragma warning restore 612, 618
        }
    }
}
