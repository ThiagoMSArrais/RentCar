using DomainValidation.Validation;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;
using TMSA.RentCar.Cadastro.Domain.Clientes.Specifications;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Validations
{
    public class ClienteAptoParaCadastroValidation : Validator<Cliente>
    {
        public ClienteAptoParaCadastroValidation(IClienteRepository clienteRepository)
        {
            var cpfDuplicado = new ClienteDevePossuirCPFUnicoSpecification(clienteRepository);
            var emailDuplicado = new ClienteDevePossuirEmailUnicoSpecification(clienteRepository);

            base.Add("cpfDuplicado", new Rule<Cliente>(cpfDuplicado, "CPF já cadastrado!"));
            base.Add("emailDuplicado", new Rule<Cliente>(emailDuplicado, "E-mail já cadastrado!"));
                
        }
    }
}
