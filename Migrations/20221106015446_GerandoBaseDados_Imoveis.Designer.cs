﻿// <auto-generated />
using System;
using Adm_Imoveis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adm_Imoveis.Migrations
{
    [DbContext(typeof(Context_db))]
    [Migration("20221106015446_GerandoBaseDados_Imoveis")]
    partial class GerandoBaseDados_Imoveis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Adm_Imoveis.Models.Imovel", b =>
                {
                    b.Property<int>("IdImovel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("DtCadastro")
                        .HasColumnType("date");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdImovel");

                    b.ToTable("tb_Imovel");
                });

            modelBuilder.Entity("Adm_Imoveis.Models.Pessoas", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdTipo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("IdPessoa");

                    b.ToTable("tb_Pessoas");
                });

            modelBuilder.Entity("Adm_Imoveis.Models.TipoPessoa", b =>
                {
                    b.Property<int>("IdTipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescricaoTipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdTipo");

                    b.ToTable("tb_TipoPessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
