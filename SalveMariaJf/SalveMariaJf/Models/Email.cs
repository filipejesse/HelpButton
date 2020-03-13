using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Threading.Tasks;

namespace SalveMariaJf.Models
{
    public class Email
    {
        SmtpClient smtpClient;
        public Email() {
            smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["User"], ConfigurationManager.AppSettings["Psw"]),
                EnableSsl = true
            };
        }

        public bool Send(Pessoa pessoa)
        {
            var mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["User"]);
            mailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["User"]));

            mailMessage.Subject = $"Urgencia para {pessoa.Nome}";
            mailMessage.Body = $"Solicitação de socorro para {pessoa.Nome}\r\nCPF: {pessoa.Cpf}\r\nLocal: {pessoa.Local}";
            mailMessage.IsBodyHtml = false;

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}