using System;
using System.Collections.Generic;
using System.Text;
using TMSA.RentCar.Cadastro.Data.Interfaces;

namespace TMSA.RentCar.Cadastro.Data.UoW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private ClienteContext _clienteContext;

        public UnitOfWork(ClienteContext clienteContext)
        {
            _clienteContext = clienteContext;
        }

        public void Commit()
        {
            _clienteContext.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_clienteContext != null)
                {
                    _clienteContext.Dispose();
                    _clienteContext = null;
                }
            }
        }
    }
}
