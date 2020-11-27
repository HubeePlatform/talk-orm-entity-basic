using Microsoft.EntityFrameworkCore.Storage;
using NotaFiscalApp.Banco;
using NotaFiscalApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotaFiscalApp.Dao
{
    public class BaseDao<T> where T: EntidadeBase
    {
        private readonly Contexto _contexto;
        private IDbContextTransaction _dbContextTransaction;

        public BaseDao()
        {
            _contexto = new Contexto();
        }
        public IQueryable<T> Query()
        {
            return _contexto.Set<T>();
        }

        public void CriarOuAlterar(T entidade)
        {
            var dbSet = _contexto.Set<T>();
            var entidadeJaSalva = dbSet.Any(e => e.Id.Equals(entidade.Id));

            if (entidadeJaSalva)
            {
                dbSet.Update(entidade);
                return;
            }

            dbSet.Add(entidade);
        }

        public void Excluir(T entidade)
        {
            entidade.DataExclusao = DateTime.Now;
            _contexto.Set<T>().Update(entidade);
        }

        public T BuscarPorId(int id)
        {
            return Query().FirstOrDefault(e => e.Id.Equals(id));
        }
              
        public void SalvarAlteracoes()
        {
            _contexto.SaveChanges();
        }

        public void IniciarTransacao()
        {
            _dbContextTransaction = _contexto.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (_dbContextTransaction is null)
                return;

            _dbContextTransaction.Commit();
            _dbContextTransaction = null;
        }

        public void Rollback()
        {
            if (_dbContextTransaction is null)
                return;

            _dbContextTransaction.Rollback();
            _dbContextTransaction = null;
        }


    }
}
