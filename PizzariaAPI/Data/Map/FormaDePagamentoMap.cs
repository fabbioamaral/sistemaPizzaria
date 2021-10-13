using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class FormaDePagamentoMap : IEntityTypeConfiguration<FormaDePagamento>
    {
        public void Configure(EntityTypeBuilder<FormaDePagamento> builder)
        {
            builder.HasKey(f => f.FormaDePagamentoId);
            builder.Property(f => f.FormaDePagamentoNome)
                            .IsRequired()
                            .HasColumnName("Forma de Pagamento")
                            .HasColumnType("varchar(20)")
                            .HasMaxLength(20);
        }
    }
}
