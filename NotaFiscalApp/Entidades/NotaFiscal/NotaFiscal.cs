using System;
using System.Collections.Generic;
using System.Text;

namespace NotaFiscalApp.Entidades.NotaFiscal
{
    public class NotaFiscal: EntidadeBase
    {
        public int Numero { get; set; }

        public Cliente Cliente { get; set; }
        public IList<NotaFiscalItem> Itens { get; set; }
    }
}
