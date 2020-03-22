using DomainValidation.Validation;
using System;
using TMSA.RentCar.Cadastro.Domain.Enderecos;

namespace TMSA.RentCar.Cadastro.Domain.Clientes
{
    public class Cliente
    {
        public Guid ClienteId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public bool Ativo { get; private set; }
        public Endereco Endereco { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Cliente()
        {

        }

        public Cliente(Guid clienteId,
                       string nome,
                       string email,
                       string cPF)
        {
            ClienteId = clienteId;
            Nome = nome;
            DefinirEmail(email);
            DefinirCPF(cPF);
            Ativo = false;
        }


        public void DefinirEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void DefinirEmail(string email)
        {
            if (this.DefinirEmailClienteScopeEhValido(email))
                Email = email;
        }

        public void DefinirCPF(string cpf)
        {
            if (this.DefinirCPFClienteScopeEhValido(cpf))
                CPF = cpf;
        }

        public void ValidarSenha(string senha)
        {
            if (this.ValidarSenhaClienteScopeEhValido(senha))
                return;
        }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        #region Constantes
        public const int SenhaMinLength = 6;
        public const int SenhaMaxLength = 30;
        #endregion
    }
}
