using Infra.Context;

namespace Test.Setup
{
    public static class TestDbContextBuilder
    {
        public static EmployeeContext BuildDbContext()
        {
            return new EmployeeContext(TestDbContextOptionsBuilder.BuildOptions());
        }
    }
}