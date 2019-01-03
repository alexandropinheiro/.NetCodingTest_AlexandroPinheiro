using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Setup
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly EmployeeContext _context;

        public DatabaseInitializer(EmployeeContext context)
        {
            _context = context;
        }

        public virtual void ApplyDatabase()
        {
            if (_context.Database.EnsureCreated()) _context.Database.Migrate();
        }
    }
}