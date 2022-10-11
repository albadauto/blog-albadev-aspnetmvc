using System.Net;
using System.Net.Mail;

namespace BlogDoDautin.Helper
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;
        public Email(IConfiguration configuration)
        {
             _configuration = configuration;
        }
        public bool Send(string email, string subject, string message)
        {
            try
            {
                var smtp = new {
                    host = _configuration.GetValue<string>("SMTP:host"),
                    name = _configuration.GetValue<string>("SMTP:name"),
                    password = _configuration.GetValue<string>("SMTP:password"),
                    username = _configuration.GetValue<string>("SMTP:username"),
                    port = _configuration.GetValue<int>("SMTP:port")
                };
                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(smtp.username, smtp.name)
                };
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.Body = message;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;

                using (SmtpClient client = new SmtpClient(smtp.host, smtp.port))
                {
                    client.Credentials = new NetworkCredential(smtp.username, smtp.password);
                    client.EnableSsl = true;
                    client.Send(mailMessage);
                    return true;
                }
            }catch(Exception err)
            {
                //Gravar log de erro ao enviar e-mail
                return false;
            }
        }
    }
}
