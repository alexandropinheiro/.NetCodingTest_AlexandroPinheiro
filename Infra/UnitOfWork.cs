using Domain;
using Infra.Context;

namespace Infra
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeContext _contexto;

        public UnitOfWork(EmployeeContext contexto)
        {
            _contexto = contexto;
        }

        public bool Commit()
        {
            return _contexto.SaveChanges() > 0;
        }        
    }
}
