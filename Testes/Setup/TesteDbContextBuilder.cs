using Infra.Context;

namespace Testes.Setup
{
    public static class TestDbContextBuilder
    {
        public static EmployeeContext BuildDbContext()
        {
            return new EmployeeContext(TestDbContextOptionsBuilder.BuildOptions());
        }
    }
}