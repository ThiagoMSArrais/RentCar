using System.Threading.Tasks;

namespace TMSA.RentCar.Core.Infra.Email
{
    public interface IEnvioEmail
    {
        Task EnviarAsync(string nome, string email, string assunto, string mensagem);
    }
}