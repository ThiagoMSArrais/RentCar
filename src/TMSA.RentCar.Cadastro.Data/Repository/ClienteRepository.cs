using System;
using System.Linq;
using TMSA.RentCar.Cadastro.Data.Context;
using TMSA.RentCar.Cadastro.Domain.Clientes;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;

namespace TMSA.RentCar.Cadastro.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteContext _db;

        public ClienteRepository(ClienteContext db)
        {
            _db = db;
        }

        public void Adicionar(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _db.Clientes.Update(cliente);
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return _db.Clientes.FirstOrDefault(c => c.CPF == cpf);
        }

        public Cliente ObterPorEmail(string email)
        {
            return _db.Clientes.FirstOrDefault(c => c.Email == email);
        }

        public Cliente ObterPorId(Guid clienteId)
        {
            return _db.Clientes.Find(clienteId);
        }
    }
}
