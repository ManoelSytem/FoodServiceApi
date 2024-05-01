﻿// <auto-generated />
using System;
using InfraEstrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfraEstrutura.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20240426043016_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Cardapio", b =>
                {
                    b.Property<int>("idCardapio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("idCardapio"));

                    b.Property<string>("delete")
                        .HasColumnType("longtext");

                    b.Property<string>("ePrincipal")
                        .HasColumnType("longtext");

                    b.Property<string>("idUser")
                        .HasColumnType("longtext");

                    b.Property<string>("titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("update")
                        .HasColumnType("longtext");

                    b.HasKey("idCardapio");

                    b.ToTable("cardapio");
                });

            modelBuilder.Entity("Dominio.Cliente", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("contato")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("dataEntrada")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("dataUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("logo")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("IdUser");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Dominio.Consumo", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigo"));

                    b.Property<string>("codMesa")
                        .HasColumnType("longtext");

                    b.Property<string>("codProduto")
                        .HasColumnType("longtext");

                    b.Property<string>("delete")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("horaPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("seqAbreMesa")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("codigo");

                    b.ToTable("consumo");
                });

            modelBuilder.Entity("Dominio.Conta", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigo"));

                    b.Property<DateTime>("dataAbertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("dataBaixaConta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("dataFechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("formaPagamento")
                        .HasColumnType("longtext");

                    b.Property<int>("numeroMesa")
                        .HasColumnType("int");

                    b.Property<string>("seqAbreMesa")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("totalTroco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("valorEntrada")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("valorSaida")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("codigo");

                    b.ToTable("conta");
                });

            modelBuilder.Entity("Dominio.FormaPagamento", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigo"));

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.HasKey("codigo");

                    b.ToTable("formapagamento");
                });

            modelBuilder.Entity("Dominio.ListaItemProduto", b =>
                {
                    b.Property<int>("codigoLista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigoLista"));

                    b.Property<string>("codMenuSeq")
                        .HasColumnType("longtext");

                    b.Property<int>("codProduto")
                        .HasColumnType("int");

                    b.Property<int>("codigoCardapio")
                        .HasColumnType("int");

                    b.Property<string>("delete")
                        .HasColumnType("longtext");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("titulo")
                        .HasColumnType("longtext");

                    b.Property<string>("update")
                        .HasColumnType("longtext");

                    b.HasKey("codigoLista");

                    b.ToTable("itemproduto");
                });

            modelBuilder.Entity("Dominio.Mesa", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigo"));

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("seqAbreMesa")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.HasKey("codigo");

                    b.ToTable("mesa");
                });

            modelBuilder.Entity("Dominio.Produto", b =>
                {
                    b.Property<int>("codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("codigo"));

                    b.Property<string>("cliente")
                        .HasColumnType("longtext");

                    b.Property<string>("delete")
                        .HasColumnType("longtext");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<string>("update")
                        .HasColumnType("longtext");

                    b.Property<float>("valor")
                        .HasColumnType("float");

                    b.HasKey("codigo");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}