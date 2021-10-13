using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.PedidoId);
            builder.Property(p => p.ValorItens)
                            .IsRequired()
                            .HasColumnName("Valor dos Itens")
                            .HasColumnType("decimal(10,2)");

            builder.Property(p => p.ValorItens)
                            .HasColumnName("Valor do Desconto")
                            .HasColumnType("decimal(10,2)");

            builder.Property(p => p.ValorTotal)
                            .IsRequired()
                            .HasColumnName("Valor Total do Pedido")
                            .HasColumnType("decimal(10,2)");

            builder.Property(p => p.DataPedido)
                            .IsRequired()
                            .HasColumnName("Data do Pedido")
                            .HasColumnType("datetime");


        }
    }
}
