using Microsoft.Extensions.DependencyInjection;
using TMSA.RentCar.Cadastro.Data.Context;
using TMSA.RentCar.Cadastro.Data.Interfaces;
using TMSA.RentCar.Cadastro.Data.Repository;
using TMSA.RentCar.Cadastro.Data.UoW;
using TMSA.RentCar.Cadastro.Domain.Clientes.Events;
using TMSA.RentCar.Cadastro.Domain.Clientes.Handlers;
using TMSA.RentCar.Cadastro.Domain.Clientes.Interfaces;
using TMSA.RentCar.Cadastro.Domain.Clientes.Services;
using TMSA.RentCar.Core.Domain.Events;
using TMSA.RentCar.Core.Domain.Handlers;
using TMSA.RentCar.Core.Domain.Interfaces;
using TMSA.RentCar.Core.Infra.Email;

namespace TMSA.RentCar.Cadastro.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            // Domain
            service.AddScoped<IClienteService, ClienteService>();

            // Infra Dados Repository
            service.AddScoped<IClienteRepository, ClienteRepository>();

            // Infra Dados
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<ClienteContext>();

            // Handlers
            service.AddScoped<IHandler<DomainNotification>, DomainNotificationHandler>();
            service.AddScoped<IHandler<ClienteCadastradoEvent>, ClienteCadastroHandler>();

            // Infra Core
            service.AddScoped<IEnvioEmail, EnvioEmail>();
        }
    }
}
