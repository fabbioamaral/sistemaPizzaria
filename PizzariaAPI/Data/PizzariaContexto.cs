using Microsoft.EntityFrameworkCore;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data
{
    public class PizzariaContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FormaDePagamento> FormasDePagamento { get; set; }
        public DbSet<PedidoProduto> PedidosProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = FABBIO; Initial Catalog = ReiDaPizza; Integrated Security = True");
        }
        protected override void OnModelCreating(ModelBuilder mB)
        {
            mB.Entity<Categoria>()
                .HasMany<Produto>(c => c.Produtos)
                .WithOne(p => p.Categoria)
                .HasForeignKey(p => p.CategoriaId);

            mB.Entity<Cliente>()
                .HasMany<Endereco>(c => c.Enderecos)
                .WithOne(e => e.Cliente)
                .HasForeignKey(e => e.ClienteId);

            mB.Entity<TaxaDeEntrega>()
                .HasMany<Endereco>(t => t.Enderecos)
                .WithOne(e => e.TaxaDeEntrega)
                .HasForeignKey(e => e.TaxaDeEntregaId);

            mB.Entity<FormaDePagamento>()
                .HasMany<Pedido>(f => f.Pedidos)
                .WithOne(p => p.FormaDePagamento)
                .HasForeignKey(p => p.FormaDePagamentoId);

            mB.Entity<Pedido>()
                .HasMany<PedidoProduto>(p => p.DetalhesDoPedido)
                .WithOne(d => d.Pedido)
                .HasForeignKey(d => d.PedidoId);

            mB.Entity<Produto>()
                .HasMany<PedidoProduto>(p => p.Pedidos)
                .WithOne(pd => pd.Produto)
                .HasForeignKey(pd => pd.ProdutoId);

            mB.Entity<Endereco>()
                .HasMany<Pedido>(e => e.Pedidos)
                .WithOne(p => p.Endereco)
                .HasForeignKey(p => p.EnderecoId);
        }
    }
}
