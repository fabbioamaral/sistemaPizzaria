using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaAPI.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);
            builder.Property(c => c.ClienteNome)
                            .IsRequired()
                            .HasColumnName("Nome do Cliente")
                            .HasColumnType("varchar(100)")
                            .HasMaxLength(100);

            builder.HasIndex(c => c.ClienteTelefone)
                            .IsUnique();

            builder.Property(c => c.ClienteTelefone)
                            .IsRequired()
                            .HasColumnName("Telefone")
                            .HasColumnType("varchar(11)")
                            .HasMaxLength(11);

            builder.Property(c => c.ObservacaoInterna)
                            .HasColumnName("Observação sobre o Cliente")
                            .HasColumnType("varchar(200)")
                            .HasMaxLength(200);

            builder.Property(c => c.DataCriacao)
                            .IsRequired()
                            .HasColumnName("Data de Criação")
                            .HasColumnType("datetime");

            builder.Property(c => c.DataUltimaAtualizacao)
                            .HasColumnName("Data da Última Atualização")
                            .HasColumnType("datetime");
        }
    }
}
