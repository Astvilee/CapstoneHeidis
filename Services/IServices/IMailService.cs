using System.Net.Mail;
using System.Threading.Tasks;

namespace Capstone.Services.IServices
{
    public interface IMailService
    {
        Task SendEmail(string to, string subject, string body, string[] cc);
    }
}
