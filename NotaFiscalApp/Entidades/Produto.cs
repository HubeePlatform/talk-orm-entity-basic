using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Entidades
{
    public class Produto: EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {
            Tags = new List<Tag>();
        }

        public IList<Tag> Tags { get; set; }
    }
}
