using System;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces
{
    public interface IClienteRepository
    {
        void Adicionar(Cliente cliente);
        void Atualizar(Cliente cliente);
        Cliente ObterPorId(Guid clienteId);
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
    }
}
