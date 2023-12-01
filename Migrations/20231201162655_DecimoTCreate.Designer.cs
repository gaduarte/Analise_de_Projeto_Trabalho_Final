﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gabriela_duarte.Models;

#nullable disable

namespace gabriela_duarte.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231201162655_DecimoTCreate")]
    partial class DecimoTCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("gabriela_duarte.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<int?>("Percentual")
                        .HasColumnType("int");

                    b.Property<double?>("Preco")
                        .HasColumnType("double");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("NotaDeVendaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("gabriela_duarte.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("NotaDeVendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("TipoDePagamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportadoraId")
                        .HasColumnType("int");

                    b.Property<int?>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("NotaDeVendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoDePagamentoId");

                    b.HasIndex("TransportadoraId");

                    b.HasIndex("VendedorId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NotaDeVendaId")
                        .HasColumnType("int");

                    b.Property<bool?>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double?>("Valor")
                        .HasColumnType("double");

                    b.HasKey("PagamentoId");

                    b.HasIndex("NotaDeVendaId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<double?>("Preco")
                        .HasColumnType("double");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("gabriela_duarte.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("TipoDePagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .HasColumnType("longtext");

                    b.Property<string>("TipoDePagamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TipoDePagamentoId");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("TipoDePagamento").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Transportadora", b =>
                {
                    b.Property<int>("TransportadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("TransportadoraId");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("gabriela_duarte.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("gabriela_duarte.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroDoCartao")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("gabriela_duarte.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("gabriela_duarte.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Item", b =>
                {
                    b.HasOne("gabriela_duarte.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Itens")
                        .HasForeignKey("NotaDeVendaId");

                    b.HasOne("gabriela_duarte.Models.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("NotaDeVenda");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("gabriela_duarte.Models.NotaDeVenda", b =>
                {
                    b.HasOne("gabriela_duarte.Models.Cliente", "Cliente")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("gabriela_duarte.Models.TipoDePagamento", "TipoDePagamento")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("TipoDePagamentoId");

                    b.HasOne("gabriela_duarte.Models.Transportadora", "Transportadora")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("TransportadoraId");

                    b.HasOne("gabriela_duarte.Models.Vendedor", "Vendedor")
                        .WithMany("NotaDeVendas")
                        .HasForeignKey("VendedorId");

                    b.Navigation("Cliente");

                    b.Navigation("TipoDePagamento");

                    b.Navigation("Transportadora");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Pagamento", b =>
                {
                    b.HasOne("gabriela_duarte.Models.NotaDeVenda", "NotaDeVenda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("NotaDeVendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotaDeVenda");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Produto", b =>
                {
                    b.HasOne("gabriela_duarte.Models.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Cliente", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("gabriela_duarte.Models.NotaDeVenda", b =>
                {
                    b.Navigation("Itens");

                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Produto", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("gabriela_duarte.Models.TipoDePagamento", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Transportadora", b =>
                {
                    b.Navigation("NotaDeVendas");
                });

            modelBuilder.Entity("gabriela_duarte.Models.Vendedor", b =>
                {
                    b.Navigation("NotaDeVendas");
                });
#pragma warning restore 612, 618
        }
    }
}
