using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Entidades
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataExclusao { get; set; }

        public EntidadeBase()
        {
            DataCriacao = DateTime.Now;
        }
    }
}
