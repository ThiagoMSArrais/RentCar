using System;
using TMSA.RentCar.Core.Domain.Interfaces;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Events
{
    public class ClienteCadastradoEvent : IDomainEvent
    {
        public DateTime DataOcorrencia { get; private set; }
        public Cliente Cliente { get; private set; }
        public string EmailTitle { get; private set; }
        public string EmailBody { get; private set; }
        public int Versao { get; private set; }

        public ClienteCadastradoEvent(Cliente cliente, DateTime dateOccured)
        {
            this.Versao = 1;
            this.Cliente = cliente;
            this.DataOcorrencia = DateTime.Now;
            this.EmailTitle = "Seja bem vindo " + cliente.Nome;
            this.EmailBody = "Obrigado por se cadastrar.";
        }

        public ClienteCadastradoEvent(Cliente cliente) : this(cliente, DateTime.Now) { }
    }
}