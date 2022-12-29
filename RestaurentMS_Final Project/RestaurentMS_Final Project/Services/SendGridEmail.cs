using Microsoft.Extensions.Options;
using RestaurentMS_Final_Project.Helpers;
using RestaurentMS_Final_Project.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Http.Headers;
using System.Text;

namespace RestaurentMS_Final_Project.Services
{
    public class SendGridEmail : ISendGridEmail
    {
        private readonly ILogger<SendGridEmail> _logger;
        public AuthMessageSenderOptions Options { get; set; }

        public SendGridEmail(ILogger<SendGridEmail> logger, IOptions<AuthMessageSenderOptions> options)
        {
            _logger = logger;
            Options = options.Value;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Options.ApiKey))
            {
                throw new Exception("Null SendGridKey");
            }
            await Execute(Options.ApiKey, subject, message, toEmail);
        }

        private async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            string host = "rapidprod-sendgrid-v1.p.rapidapi.com";
            var res = "{\"personalizations\": [{\"to\": [{\"email\": \"" + toEmail + "\"}],\"subject\": \"" + subject + "\"}],\"from\": {\"email\": \"from_address@example.com\"}, \"content\": [ {\"type\": \"text/html\",\"value\": \"" + message + "\" }]}";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://rapidprod-sendgrid-v1.p.rapidapi.com/mail/send"),
                Headers =
                {

                    { "X-RapidAPI-Key", apiKey },
                    { "X-RapidAPI-Host", host }

                },
                //Content = new StringContent(res, Encoding.UTF8, "application/json"),
                
                Content = new StringContent(res)
                {
                    Headers =
                        {
                            ContentType = new MediaTypeHeaderValue("application/json")
                        }
                }



            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

            }

        }

    }
}




