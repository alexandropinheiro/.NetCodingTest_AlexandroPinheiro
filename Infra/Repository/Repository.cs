using System.Collections.Generic;
using System.Linq;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Domain.Base;
using System;
using System.Linq.Expressions;

namespace Infra.Repository
{
    public class Repository<TEntity> : IRepositoryBase<TEntity> where TEntity : EntidadeBase
    {
        protected EmployeeContext _context { get; set; }
        protected DbSet<TEntity> DbSet;

        public Repository(EmployeeContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public virtual void Gravar(TEntity objeto)
        {
            DbSet.Add(objeto);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Atualizar(TEntity objeto)
        {
            _context.Set<TEntity>().Update(objeto);
            _context.SaveChanges();
        }

        public void Excluir(TEntity objeto)
        {
            _context.Set<TEntity>().Remove(objeto);
            _context.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> Obter(Expression<Func<TEntity, bool>> condicao)
        {
            return _context.Set<TEntity>()
                .Where(condicao)
                .ToList();
        }
    }
}
