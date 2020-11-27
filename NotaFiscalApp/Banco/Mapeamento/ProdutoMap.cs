using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotaFiscalApp.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Banco.Mapeamento
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(Produto));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Preco)
                .HasColumnType("DECIMAL(14,2)");

            builder
                .HasMany(p => p.Tags)
                .WithMany(t => t.Produtos);

            builder.HasQueryFilter(e => e.DataExclusao == null);
        }
    }
}
