using Infra.Context;
using Infra.Setup;
using Testes.Setup;

namespace Testes
{
    public abstract class TesteBase
    {
        protected EmployeeContext Context;
        protected IDatabaseInitializer databaseInitializer;        

        protected void Setup()
        {
            Context = TestDbContextBuilder.BuildDbContext();
            databaseInitializer = new DatabaseInitializer(Context);
            
            databaseInitializer.ApplyMigrationsIfPossible();
            //databaseInitializer.Seed();
        }
                
        protected void TearDown()
        {
            Context.Database.EnsureDeleted();
            databaseInitializer = null;
        }
    }
}