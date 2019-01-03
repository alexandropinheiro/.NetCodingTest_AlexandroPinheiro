using Infra.Context;

namespace Infra.Setup
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly EmployeeContext _context;

        public DatabaseInitializer(EmployeeContext context)
        {
            _context = context;
        }

        public virtual bool ApplyDatabase()
        {
            return _context.Database.EnsureCreated();
        }
    }
}