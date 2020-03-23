using System;

namespace TMSA.RentCar.Cadastro.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}