using System.Threading.Tasks;

namespace dim.Services
{
    public interface IMailServices
    {
        Task SendMailAsync(
            string fromEmail,
            string fromName,
            string subjectEmail,
            string toEmail,
            string toEmailName,
            string content,
            string htmlContents,
            string phoneNumber);
    }
}
