using System;
using System.Collections.Generic;
using System.Text;
using TMSA.RentCar.Core.Domain.ValueObjects;

namespace TMSA.RentCar.Cadastro.Domain.Enderecos
{
    public static class EnderecoScopes
    {
        public static bool DefinirLogradouroScopeEhValido(this Endereco endereco, string logradouro)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(logradouro, "O logradouro é obrigatório")
                );
        }

        public static bool DefinirCEPScopeEhValido(this Endereco endereco, string cep)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(cep, "O cep é obrigatório"),
                    AssertionConcern.AssertFixedLength(cep, 8, "O CEP está em tamanho incorreto")
                );
        }

        public static bool DefinirNumeroScopeEhValido(this Endereco endereco, string numero)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(numero, "O número é obrigatório")
                );
        }

        public static bool DefinirBairroScopeEhValido(this Endereco endereco, string bairro)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(bairro, "O bairro é obrigatório")
                );
        }

        public static bool DefinirCidadeScopeEhValido(this Endereco endereco, string cidade)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(cidade, "A cidade é obrigatório")
                );
        }

        public static bool DefinirEstadoScopeEhValido(this Endereco endereco, string estado)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotNullOrEmpty(estado, "O estado não existe")
                );
        }
    }
}
