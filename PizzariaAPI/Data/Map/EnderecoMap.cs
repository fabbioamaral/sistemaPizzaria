using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.EnderecoId);
            builder.Property(e => e.Logradouro)
                            .IsRequired()                            
                            .HasColumnType("varchar(100)")
                            .HasMaxLength(100);

            builder.Property(e => e.NumeroEndereco)
                            .IsRequired()
                            .HasColumnName("Número")
                            .HasColumnType("int");

            builder.Property(e => e.Complemento)
                            .HasColumnType("varchar(10)")
                            .HasMaxLength(10);

            builder.Property(e => e.Bairro)
                            .IsRequired()
                            .HasColumnType("varchar(60)")
                            .HasMaxLength(60);

            builder.Property(e => e.Cidade)
                            .IsRequired()
                            .HasColumnType("varchar(60)")
                            .HasMaxLength(60);

            builder.Property(e => e.Referencia)                
                            .HasColumnType("varchar(160)")
                            .HasMaxLength(160);
        }
    }
}
