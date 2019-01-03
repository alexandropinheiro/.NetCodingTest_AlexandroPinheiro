using Microsoft.Extensions.DependencyInjection;
using Domain;
using Infra;
using Infra.Context;
using Ioc.Extensions;

namespace Ioc
{
    public static class InjecaoDeDependencia
    {        
        public static IServiceCollection RegistrarDependenciasDoIoC(this IServiceCollection service)
        {
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<EmployeeContext>();

            service.InjetarClassesQueImplementam(typeof(IRepository));

            return service;
        }
    }
}
