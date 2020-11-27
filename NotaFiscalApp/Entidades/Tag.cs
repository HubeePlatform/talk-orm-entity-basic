using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Entidades
{
    public class Tag: EntidadeBase
    {
        public string Nome { get; set; }

        public IList<Produto> Produtos { get; set; }

        public Tag()
        {
            Produtos = new List<Produto>();
        }
    }
}
