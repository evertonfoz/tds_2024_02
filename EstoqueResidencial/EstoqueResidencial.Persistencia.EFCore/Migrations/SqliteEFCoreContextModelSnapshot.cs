﻿// <auto-generated />
using EstoqueResidencial.Persistencia.EFCore.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstoqueResidencial.Persistencia.EFCore.Migrations
{
    [DbContext(typeof(SqliteEFCoreContext))]
    partial class SqliteEFCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("EstoqueResidencial.Modelo.Basicas.FornecedorModelo", b =>
                {
                    b.Property<int>("FornecedorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("FornecedorID");

                    b.ToTable("Fornecedores");
                });
            modelBuilder.Entity("EstoqueResidencial.Modelo.Basicas.Localizacao", b =>
                {
                    b.Property<int>("LocalizacaoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("LocalizacaoID");

                    b.ToTable("Localizacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
