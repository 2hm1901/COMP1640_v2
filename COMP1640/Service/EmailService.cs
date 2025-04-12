using System.Net;
using System.Net.Mail;

namespace COMP1640.Service;

public interface IEmailService
{
    Task SendEmailAsync(string toEmail, string subject, string body);
}

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var smtpClient = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("minhbee203@gmail.com", "fykmyapdmkxzaajb"),
            EnableSsl = true
        };

        var message = new MailMessage
        {
            From = new MailAddress("minhbee203@gmail.com"),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };

        message.To.Add(toEmail);

        await smtpClient.SendMailAsync(message);
    }
}