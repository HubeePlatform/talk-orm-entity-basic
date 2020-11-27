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

            var tagDao = new BaseDao<Tag>();

            tagDao.IniciarTransacao();


            var tag = new Tag() { Nome = "Genérico" };
            tagDao.CriarOuAlterar(tag);
            tagDao.SalvarAlteracoes();
            tagDao.Commit();

            var firstTag = tagDao.Query().FirstOrDefault();
            Console.WriteLine("Nome cadastrado: " + firstTag.Nome);

            tag.Nome = "Genérico alterado";
            tagDao.CriarOuAlterar(tag);
            tagDao.SalvarAlteracoes();

            firstTag = tagDao.Query().FirstOrDefault();
            Console.WriteLine("Nome alterado: " + firstTag.Nome);

            tagDao.Excluir(tag);
            firstTag = tagDao.Query().FirstOrDefault();
            Console.WriteLine("Tag apagada: " + firstTag is null);

            Console.ReadKey();
        }
    }
}
