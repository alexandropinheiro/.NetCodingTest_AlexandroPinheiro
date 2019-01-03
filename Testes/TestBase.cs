using Infra.Context;
using Infra.Setup;
using Test.Setup;

namespace Test
{
    public abstract class TestBase
    {
        protected EmployeeContext Context;
        protected IDatabaseInitializer databaseInitializer;        

        protected void Setup()
        {
            Context = TestDbContextBuilder.BuildDbContext();
            databaseInitializer = new DatabaseInitializer(Context);
            
            databaseInitializer.ApplyDatabase();
        }
                
        protected void TearDown()
        {
            Context.Database.EnsureDeleted();
            databaseInitializer = null;
        }
    }
}