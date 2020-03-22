using System;
using TMSA.RentCar.Core.Domain.Helpers;

namespace TMSA.RentCar.Cadastro.Domain.Enderecos
{
    public class Endereco
    {
        public Guid EnderecoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }

        protected Endereco()
        {
                
        }

        public Endereco(Guid enderecoId,
                        string logradouro,
                        string complemento,
                        string numero, 
                        string bairro, 
                        string cidade, 
                        string estado, 
                        string cEP)
        {
            EnderecoId = enderecoId;
            DefinirLogradouro(logradouro);
            DefinirComplemento(complemento);
            DefinirNumero(numero);
            DefinirBairro(bairro);
            DefinirCidade(cidade);
            DefinirEstado(estado);
            DefinirCep(cEP);
        }

        public void DefinirLogradouro(string logradouro)
        {
            if (this.DefinirLogradouroScopeEhValido(logradouro))
                Logradouro = TextoHelper.ToTitleCase(logradouro);
        }

        public void DefinirCep(string cep)
        {
            if (this.DefinirCEPScopeEhValido(cep))
                CEP = cep;
        }

        public void DefinirNumero(string numero)
        {
            if (this.DefinirNumeroScopeEhValido(numero))
                Numero = numero;
        }

        public void DefinirComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento))
                complemento = "";

            Complemento = TextoHelper.ToTitleCase(complemento);
        }

        public void DefinirBairro(string bairro)
        {
            if (this.DefinirBairroScopeEhValido(bairro))
                Bairro = TextoHelper.ToTitleCase(bairro);
        }

        public void DefinirCidade(string cidade)
        {
            if (this.DefinirCidadeScopeEhValido(cidade))
                Cidade = cidade;
        }

        public void DefinirEstado(string estado)
        {
            if (this.DefinirEstadoScopeEhValido(estado))
                Estado = estado;
        }

        public override string ToString()
        {
            return Logradouro + ", " + Numero + " - " + Complemento + " <br /> " + Bairro + " - " + Cidade + "/" + Estado;
        }

    }
}
