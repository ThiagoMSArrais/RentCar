using System;
using System.Collections.Generic;

namespace TMSA.RentCar.Core.Domain.Interfaces
{
    public interface IContainer
    {
        T GetInstance<T>();
        object GetInstance(Type serviceType);
        IEnumerable<T> GetAllInstance<T>();
        IEnumerable<object> GetAllInstance(Type serviceType);
    }
}
