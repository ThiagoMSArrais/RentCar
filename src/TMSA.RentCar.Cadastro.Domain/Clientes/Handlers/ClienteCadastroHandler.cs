using System.Collections.Generic;
using TMSA.RentCar.Cadastro.Domain.Clientes.Events;
using TMSA.RentCar.Core.Domain.Interfaces;
using TMSA.RentCar.Core.Infra.Email;

namespace TMSA.RentCar.Cadastro.Domain.Clientes.Handlers
{
    public class ClienteCadastroHandler : IHandler<ClienteCadastradoEvent>
    {
        private List<ClienteCadastradoEvent> _notifications;
        private readonly IEnvioEmail _envioEmail;

        public ClienteCadastroHandler(IEnvioEmail envioEmail)
        {
            _envioEmail = envioEmail;
        }

        public void Handle(ClienteCadastradoEvent args)
        {
            _envioEmail.EnviarAsync(args.Cliente.Nome,
                args.Cliente.Email,
                args.EmailTitle,
                args.EmailBody);
        }

        public IEnumerable<ClienteCadastradoEvent> Notify()
        {
            return GetValues();
        }

        public bool HasNotification()
        {
            return GetValues().Count > 0;
        }

        public List<ClienteCadastradoEvent> GetValues()
        {
            return _notifications;
        }
        
        public void Dispose()
        {
            _notifications = new List<ClienteCadastradoEvent>();
        }
    }
}
