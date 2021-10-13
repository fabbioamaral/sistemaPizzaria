using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);
            builder.Property(p => p.ProdutoNome)
                            .IsRequired()
                            .HasColumnName("Nome do Cliente")
                            .HasColumnType("varchar(100)")
                            .HasMaxLength(100);

            builder.Property(p => p.Preco)
                            .IsRequired()
                            .HasColumnName("Preço")
                            .HasColumnType("decimal(18,2)");
        }
    }
}
