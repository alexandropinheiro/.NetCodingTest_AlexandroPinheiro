using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Base
{
    public interface IRepositoryBase<T> : IRepository where T : EntidadeBase
    {
        void Atualizar(T objeto);
        void Gravar(T objeto);
        void Excluir(T objeto);
        List<T> ObterTodos();
        List<T> Obter(Expression<Func<T, bool>> condicao);
        T ObterPorId(int id);
    }
}
