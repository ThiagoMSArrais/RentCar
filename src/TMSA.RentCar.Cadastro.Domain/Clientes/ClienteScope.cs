using TMSA.RentCar.Core.Domain.ValueObjects;

namespace TMSA.RentCar.Cadastro.Domain.Clientes
{
    public static class ClienteScope
    {
        public static bool DefinirSenhaClienteEhValido(this Cliente cliente, string password, string confirmPassword)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(password, "A senha é obrigatório"),
                    AssertionConcern.AssertNotNullOrEmpty(confirmPassword, "A confirmação de senha é obrigatória"),
                    AssertionConcern.AssertAreEquals(password, confirmPassword, "As senhas são iguais")
                );
        }

        public static bool ValidarSenhaClienteScopeEhValido(this Cliente cliente, string password)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(password, "A senha é obrigatória"),
                    AssertionConcern.AssertLength(password, Cliente.SenhaMinLength, Cliente.SenhaMaxLength, "O tamanho da senha não corresponde") 
                );
        }

        public static bool DefinirEmailClienteScopeEhValido(this Cliente cliente, string email)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertLength(email, 5, 254, "E-mail em tamanho incorreto"),
                    AssertionConcern.AssertNotNullOrEmpty(email, "O e-mail obrigatório")
                );
        }

        public static bool DefinirCPFClienteScopeEhValido(this Cliente cliente, string cpf)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertFixedLength(cpf, 11, "CPF em tamanho incorreto"),
                    AssertionConcern.AssertNotNullOrEmpty(cpf, "O CPF é obrigatório")
                );
        }
    }
}
