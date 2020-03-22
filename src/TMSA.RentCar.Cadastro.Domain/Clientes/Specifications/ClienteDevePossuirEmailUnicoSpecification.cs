using DomainValidation.Interfaces.Specification;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Specifications
{
    public class ClienteDevePossuirEmailUnicoSpecification : ISpecification<Cliente>
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteDevePossuirEmailUnicoSpecification(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool IsSatisfiedBy(Cliente cliente)
        {
            return _clienteRepository.ObterPorEmail(cliente.Email) == null;
        }
    }
}
