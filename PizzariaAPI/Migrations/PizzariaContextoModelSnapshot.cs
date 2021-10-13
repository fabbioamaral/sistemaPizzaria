﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzariaAPI.Data;

namespace PizzariaAPI.Migrations
{
    [DbContext(typeof(PizzariaContexto))]
    partial class PizzariaContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzariaAPI.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClienteNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClienteTelefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("ObservacaoInterna")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroEndereco")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxaDeEntregaId")
                        .HasColumnType("int");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TaxaDeEntregaId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PizzariaAPI.Models.FormaDePagamento", b =>
                {
                    b.Property<int>("FormaDePagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FormaDePagamentoNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormaDePagamentoId");

                    b.ToTable("FormaDePagamento");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Desconto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<int>("FormaDePagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorItens")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("FormaDePagamentoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("PizzariaAPI.Models.PedidoDetalhes", b =>
                {
                    b.Property<int>("PedidoDetalhesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DescontoNoItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("PedidoDetalhesId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidoDetalhes");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProdutoNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("PizzariaAPI.Models.TaxaDeEntrega", b =>
                {
                    b.Property<int>("TaxaDeEntregaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TaxaDeEntregaId");

                    b.ToTable("TaxaDeEntrega");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Endereco", b =>
                {
                    b.HasOne("PizzariaAPI.Models.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaAPI.Models.TaxaDeEntrega", "TaxaDeEntrega")
                        .WithMany("Enderecos")
                        .HasForeignKey("TaxaDeEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TaxaDeEntrega");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Pedido", b =>
                {
                    b.HasOne("PizzariaAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaAPI.Models.Endereco", "Endereco")
                        .WithMany("Pedidos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaAPI.Models.FormaDePagamento", "FormaDePagamento")
                        .WithMany("Pedidos")
                        .HasForeignKey("FormaDePagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Endereco");

                    b.Navigation("FormaDePagamento");
                });

            modelBuilder.Entity("PizzariaAPI.Models.PedidoDetalhes", b =>
                {
                    b.HasOne("PizzariaAPI.Models.Pedido", "Pedido")
                        .WithMany("DetalhesDoPedido")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaAPI.Models.Produto", "Produto")
                        .WithMany("Pedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Produto", b =>
                {
                    b.HasOne("PizzariaAPI.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Endereco", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PizzariaAPI.Models.FormaDePagamento", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Pedido", b =>
                {
                    b.Navigation("DetalhesDoPedido");
                });

            modelBuilder.Entity("PizzariaAPI.Models.Produto", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PizzariaAPI.Models.TaxaDeEntrega", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
