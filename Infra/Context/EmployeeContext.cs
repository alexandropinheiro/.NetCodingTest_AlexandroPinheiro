using Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Infra.Extensions;
using Infra.Mapping;
using System.IO;

namespace Infra.Context
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Vendas { get; set; }

        private readonly DbContextOptions _options;

        public EmployeeContext() { }

        public EmployeeContext(DbContextOptions options) : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.AddConfiguration(new EmployeeMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_options == null)
            {
                var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));                
            }
            else
            {
                var dbContextBuilder = new DbContextOptionsBuilder(_options);               
                optionsBuilder = dbContextBuilder;
            }
        }
    }
}
    