namespace RestaurentMS_Final_Project.Interfaces
{
    public interface ISendGridEmail
    {
        public Task SendEmailAsync(string toEmail, string subject, string message);
    }
}
