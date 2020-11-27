using Microsoft.EntityFrameworkCore;
using NotaFiscalApp.Banco;
using NotaFiscalApp.Dao;
using NotaFiscalApp.Entidades;
using System;
using System.Linq;

namespace NotaFiscalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CriarProduto com tag     
            //Criar Cliente
            //Criar Notas Fiscais   
            //Transcations

            //Buscar Nota por Id
            //Bucar Nota Por numero
            //Ordenação
            //Skip take


            var produtoDao = new BaseDao<Produto>();
            Console.WriteLine("Salvo!");
            Console.ReadKey();
        }
    }
}
