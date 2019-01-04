using Infra.Context;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Test.Setup
{
    public static class TestDbContextOptionsBuilder
    {
        public static DbContextOptions BuildOptions()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeContext>();

            var sqliteConnection = new SqliteConnection("DataSource=:memory:");
            sqliteConnection.Open();

            optionsBuilder.UseSqlite(sqliteConnection);

            return optionsBuilder.Options;
        }
    }
}