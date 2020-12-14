using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace dim.Services
{
    public class SendGridServices : IMailServices
    {
        private readonly IConfiguration configuration;

        public SendGridServices(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendMailAsync(string fromEmail,string fromName, string subjectEmail,string toEmail,string toEmailName, string content,string htmlContents)
        {
            ;
            var apiKey = this.configuration["SendGrid:APIKey"];
            ;
            var client = new SendGridClient(apiKey);

            if (string.IsNullOrWhiteSpace(subjectEmail) && string.IsNullOrWhiteSpace(htmlContents))
            {
                throw new ArgumentException("Subject and message should be provided.");
            }

            var from = new EmailAddress(fromEmail, fromName);
            var subject = subjectEmail;
            var to = new EmailAddress(toEmail, toEmailName);
            var plainTextContent = content;
            var htmlContent = htmlContents;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            try
            {
                var response = await client.SendEmailAsync(msg);
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(await response.Body.ReadAsStringAsync());
                ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
