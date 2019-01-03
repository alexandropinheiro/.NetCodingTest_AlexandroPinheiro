namespace Infra.Setup
{
    public interface IDatabaseInitializer
    {
        bool ApplyMigrationsIfPossible();
        //void Seed();
    }
}
