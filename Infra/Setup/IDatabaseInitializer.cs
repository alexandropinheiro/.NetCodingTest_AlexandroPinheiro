﻿namespace Infra.Setup
{
    public interface IDatabaseInitializer
    {
        void ApplyDatabase();
        //void Seed();
    }
}
