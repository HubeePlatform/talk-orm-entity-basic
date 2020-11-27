using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotaFiscalApp.Entidades.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Banco.Mapeamento
{
    public class NotaFiscalMap : IEntityTypeConfiguration<NotaFiscal>
    {
        public void Configure(EntityTypeBuilder<NotaFiscal> builder)
        {
            builder.ToTable(nameof(NotaFiscal));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Numero)
                .IsRequired();

            builder.Property(e => e.DataCriacao)
                .IsRequired();

            builder
                .HasMany(e => e.Itens)
                .WithOne()
                .IsRequired();

            builder.HasQueryFilter(e => e.DataExclusao == null);
        }
    }
}
