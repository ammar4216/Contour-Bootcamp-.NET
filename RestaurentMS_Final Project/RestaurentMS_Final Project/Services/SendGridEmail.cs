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
            //if (string.IsNullOrEmpty(Options.ApiKey))
            //{
            //    throw new Exception("Null SendGridKey");
            //}
            await Execute(subject, message, toEmail);
        }

        private async Task Execute(string subject, string message, string toEmail)
        {
            //var client = new SendGridClient(apiKey);
            //var msg = new SendGridMessage()
            //{
            //    From = new EmailAddress("aym4216@gmail.com"),
            //    Subject = subject,
            //    PlainTextContent = message,
            //    HtmlContent = message
            //};
            //msg.AddTo(new EmailAddress(toEmail));

            //// Disable click tracking.
            //// See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            //msg.SetClickTracking(false, false);
            //var response = await client.SendEmailAsync(msg);
            //var dummy = response.StatusCode;
            //var dummy2 = response.Headers;
            //_logger.LogInformation(response.IsSuccessStatusCode
            //                       ? $"Email to {toEmail} queued successfully!"
            //                       : $"Failure Email to {toEmail}");


            var res = "{\"personalizations\": [{\"to\": [{\"email\": \"" + toEmail + "\"}],\"subject\": \"" + subject + "\"}],\"from\": {\"email\": \"from_address@example.com\"}, \"content\": [ {\"type\": \"text/html\",\"value\": \"" + message + "\" }]}";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://rapidprod-sendgrid-v1.p.rapidapi.com/mail/send"),
                Headers =
                {
                    { "X-RapidAPI-Key", "fa909b48dcmsh6a563a10771124ap176d96jsn1254af686ff5" },
                    { "X-RapidAPI-Host", "rapidprod-sendgrid-v1.p.rapidapi.com" },


                },
                Content = new StringContent(res, Encoding.UTF8, "application/json"),

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




