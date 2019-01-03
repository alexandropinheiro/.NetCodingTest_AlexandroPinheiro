using Domain.Employees;
using Infra.Context;

namespace Infra.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext context) : base(context)
        {
            
        }
    }
}
