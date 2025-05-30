﻿// <auto-generated />
using AutoBrands.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AutoBrands.Infrastructure.Migrations
{
    [DbContext(typeof(AutoBrandsDbContext))]
    [Migration("20250519150550_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AutoBrands.Domain.Entities.MarcaAuto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MarcasAutos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Toyota"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Ford"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Honda"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
