using Microsoft.EntityFrameworkCore;
using NotaFiscalApp.Banco.Mapeamento;
using NotaFiscalApp.Entidades;
using NotaFiscalApp.Entidades.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Banco
{
    public class Contexto: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<NotaFiscal> NotasFiscais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                return;
            }

            optionsBuilder.UseNpgsql("Host=localhost;Port=5555;Database=talk_orm;Username=talk_orm;Password=123456@big");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityByDefaultColumns();

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new NotaFiscalMap());
        }
    }
}
