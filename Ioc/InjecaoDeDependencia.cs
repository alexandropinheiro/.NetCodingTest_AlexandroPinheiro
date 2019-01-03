using Domain.Employees;
using Microsoft.Extensions.DependencyInjection;
using Domain;
using Infra;
using Infra.Context;
using Infra.Repository;

namespace Ioc
{
    public class InjecaoDeDependencia
    {
        public static void RegisterServices(IServiceCollection services)
        {            
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EmployeeContext>();
        }
    }
}
