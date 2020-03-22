using DomainValidation.Interfaces.Specification;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Specifications
{
    public class ClienteDevePossuirCPFUnicoSpecification : ISpecification<Cliente>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDevePossuirCPFUnicoSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _clienteRepository.ObterPorCpf(cliente.CPF) == null;
        }
    }
}
