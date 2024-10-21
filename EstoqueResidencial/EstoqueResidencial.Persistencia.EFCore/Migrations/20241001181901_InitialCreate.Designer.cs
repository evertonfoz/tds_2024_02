﻿// <auto-generated />
using EstoqueResidencial.Persistencia.EFCore.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueResidencial.Persistencia.EFCore.Migrations
{
    [DbContext(typeof(SqliteEFCoreContext))]
    [Migration("20241001181901_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("EstoqueResidencial.Modelo.Basicas.CategoriaModelo", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
