using Capstone.Services.IServices;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Capstone.Services
{
    public class MailService : IMailService
    {
        private readonly SmtpClient _smtpClient;

        public MailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task SendEmail(string to,string subject,string body,string[]cc)
        {
            MailMessage mail = new MailMessage();
            //Setting From , To and CC
            mail.From = new MailAddress("info@heidiswater.com", "Heidis Water");
            mail.To.Add(new MailAddress(to));
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            foreach (var item in cc)
            {
                mail.CC.Add(new MailAddress(item));
            }
           await _smtpClient.SendMailAsync(mail);

        }
    }
}
