using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {

        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.CategoriaId);
            builder.Property(c => c.CategoriaNome)
                            .IsRequired()
                            .HasColumnName("Nome da Categoria")
                            .HasColumnType("varchar(100)")
                            .HasMaxLength(100);
        }
    }
}
