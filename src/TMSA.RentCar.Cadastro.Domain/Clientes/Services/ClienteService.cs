using DomainValidation.Validation;
using System.Linq;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;
using TMSA.RentCar.Cadastro.Domain.Clientes.Validations;
using TMSA.RentCar.Core.Domain.Events;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente cliente)
        {
            if (PossuiConformidade(new ClienteAptoParaCadastroValidation(_clienteRepository).Validate(cliente)))
                _clienteRepository.Adicionar(cliente);

            return cliente;
        }

        private static bool PossuiConformidade(ValidationResult validationResult)
        {
            if (validationResult == null) return true;
            var notifications = validationResult.Erros.Select(validationError => new DomainNotification(validationError.ToString(), validationError.Message)).ToList();
            if (!notifications.Any()) return true;
            notifications.ToList().ForEach(DomainEvent.Raise);
            return false;
        }
    }
}
