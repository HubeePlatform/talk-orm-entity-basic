﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotaFiscalApp.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Banco.Mapeamento
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable(nameof(Tag));

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasQueryFilter(e => e.DataExclusao == null);
        }
    }
}
