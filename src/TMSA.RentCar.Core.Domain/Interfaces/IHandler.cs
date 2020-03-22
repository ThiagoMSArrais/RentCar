using System;
using System.Collections.Generic;
using System.Text;

namespace TMSA.RentCar.Core.Domain.Interfaces
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotification();
        List<T> GetValues();
    }
}
