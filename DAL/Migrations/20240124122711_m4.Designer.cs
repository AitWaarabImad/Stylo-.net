﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240124122711_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Marque", b =>
                {
                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nom");

                    b.ToTable("marques");
                });

            modelBuilder.Entity("DAL.Entities.Stylo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomMarque")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NomMarque");

                    b.HasIndex("NomType");

                    b.ToTable("stylos");
                });

            modelBuilder.Entity("DAL.Entities.TypeSt", b =>
                {
                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Nom");

                    b.ToTable("types");
                });

            modelBuilder.Entity("DAL.Entities.Stylo", b =>
                {
                    b.HasOne("DAL.Entities.Marque", "Marque")
                        .WithMany()
                        .HasForeignKey("NomMarque")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.TypeSt", "Type")
                        .WithMany()
                        .HasForeignKey("NomType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marque");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
