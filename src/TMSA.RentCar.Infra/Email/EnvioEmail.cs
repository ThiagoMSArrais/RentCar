using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TMSA.RentCar.Core.Infra.Email
{
    public class EnvioEmail : IEnvioEmail
    {
        public async Task EnviarAsync(string nome, string email, string assunto, string mensagem)
        {
            using (var client = new SmtpClient())
            {
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("user@gmail.com", "password");

                var mm = new MailMessage("donotreply@domain.com", email, assunto, mensagem)
                {
                    BodyEncoding = Encoding.UTF8,
                    DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
                };

                //await client.SendMailAsync(mm);
                await Task.FromResult(0);
            }
        }
    }
}
