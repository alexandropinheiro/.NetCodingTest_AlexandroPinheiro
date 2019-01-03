using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Test.Setup
{
    public static class TestDbContextOptionsBuilder
    {
        public static DbContextOptions BuildOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeContext>();
            
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.development.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            return optionsBuilder.Options;
        }
    }
}