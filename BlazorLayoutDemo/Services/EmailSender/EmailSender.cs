using BlazorLayoutDemo.Entity;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace BlazorLayoutDemo.Services;

public class EmailSender(IConfiguration configuration) : IEmailSender<ApplicationUser>
{
    private readonly IConfiguration configuration = configuration;

    public async Task SendEmailAsync(string to, string subject, string body, string? from = null)
    {
        var _EmailFrom = configuration.GetSection("SmtpSettings:From").Value;
        var _SmtpHost = configuration.GetSection("SmtpSettings:Host").Value;
        var value = configuration.GetSection("SmtpSettings:Port").Value;
        int _SmtpPort = Convert.ToInt32(value);
        var _SmtpUser = configuration.GetSection("SmtpSettings:Username").Value;
        var _SmtpPass = configuration.GetSection("SmtpSettings:Password").Value;

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Administrator", from ?? _EmailFrom));
        message.To.Add(new MailboxAddress("", to));
        message.Subject = subject;
        BodyBuilder builder = new();
        // create message
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Administrator", from ?? _EmailFrom));
        email.To.Add(new MailboxAddress("", to));
        email.Subject = subject;
        builder.HtmlBody = body;
        email.Body = builder.ToMessageBody();

        // send email
        using var smtp = new SmtpClient();
        smtp.ServerCertificateValidationCallback = MySslCertificateValidationCallback!;
        smtp.Connect(_SmtpHost, _SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(_SmtpUser, _SmtpPass);
        await smtp.SendAsync(email);
        smtp.Disconnect(true);

    }
    public async Task SendMessageAsync(string name, string from, string subject, string body)
    {
        var _EmailFrom = configuration.GetSection("SmtpSettings:From").Value;
        var _SmtpHost = configuration.GetSection("SmtpSettings:Host").Value;
        var value = configuration.GetSection("SmtpSettings:Port").Value;
        int _SmtpPort = Convert.ToInt32(value);
        var _SmtpUser = configuration.GetSection("SmtpSettings:Username").Value;
        var _SmtpPass = configuration.GetSection("SmtpSettings:Password").Value;
        string ToAddress = "admin@frenzyzone.com";
        string ToAddressTitle = "Message from StoreMvc";




        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(name, from ?? _EmailFrom));
        message.To.Add(new MailboxAddress(ToAddressTitle, ToAddress));
        message.Subject = subject;
        BodyBuilder builder = new();
        // create message
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Administrator", from ?? _EmailFrom));
        email.To.Add(new MailboxAddress(ToAddressTitle, ToAddress));
        email.Subject = subject;
        builder.HtmlBody = body;
        email.Body = builder.ToMessageBody();

        // send email
        using var smtp = new SmtpClient();
        smtp.ServerCertificateValidationCallback = MySslCertificateValidationCallback!;
        smtp.Connect(_SmtpHost, _SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(_SmtpUser, _SmtpPass);
        await smtp.SendAsync(email);
        smtp.Disconnect(true);

    }
    static bool MySslCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        // If there are no errors, then everything went smoothly.
        if (sslPolicyErrors == SslPolicyErrors.None)
            return true;

        // Note: MailKit will always pass the host name string as the `sender` argument.
        var host = (string)sender;

        if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) != 0)
        {
            // This means that the remote certificate is unavailable. Notify the user and return false.
            Console.WriteLine("The SSL certificate was not available for {0}", host);
            return false;
        }

        if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) != 0)
        {
            // This means that the server's SSL certificate did not match the host name that we are trying to connect to.
            if (certificate is not null)
            {
                var cn = certificate is X509Certificate2 certificate2 ? certificate2.GetNameInfo(X509NameType.SimpleName, false) : certificate.Subject;

                Console.WriteLine("The Common Name for the SSL certificate did not match {0}. Instead, it was {1}.", host, cn);
                return false;
            }
        }

        // The only other errors left are chain errors.
        Console.WriteLine("The SSL certificate for the server could not be validated for the following reasons:");

        // The first element's certificate will be the server's SSL certificate (and will match the `certificate` argument)
        // while the last element in the chain will typically either be the Root Certificate Authority's certificate -or- it
        // will be a non-authoritative self-signed certificate that the server admin created. 
        if (chain is not null)
        {
            foreach (var element in chain.ChainElements)
            {
                // Each element in the chain will have its own status list. If the status list is empty, it means that the
                // certificate itself did not contain any errors.
                if (element.ChainElementStatus.Length == 0)
                    continue;

                Console.WriteLine("\u2022 {0}", element.Certificate.Subject);
                foreach (var error in element.ChainElementStatus)
                {
                    // `error.StatusInformation` contains a human-readable error string while `error.Status` is the corresponding enum value.
                    Console.WriteLine("\t\u2022 {0}", error.StatusInformation);
                }
            }
        }

        return false;
    }

    public async Task SendConfirmationLinkAsync(ApplicationUser user, string _email, string confirmationLink)
    {
        //Log.Information("SendConfirmationLinkAsync," + user + "" + _email + "" + confirmationLink);
        var _EmailFrom = configuration.GetSection("SmtpSettings:From").Value;
        var _SmtpHost = configuration.GetSection("SmtpSettings:Host").Value;
        var value = configuration.GetSection("SmtpSettings:Port").Value;
        int _SmtpPort = Convert.ToInt32(value);
        var _SmtpUser = configuration.GetSection("SmtpSettings:Username").Value;
        var _SmtpPass = configuration.GetSection("SmtpSettings:Password").Value;

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        message.To.Add(new MailboxAddress("", _email));
        message.Subject = "Confirmation Link";
        BodyBuilder builder = new();
        // create message
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        email.To.Add(new MailboxAddress("", _email));
        email.Subject = "Confirmation Link";
        builder.HtmlBody = confirmationLink;
        email.Body = builder.ToMessageBody();

        // send email
        using var smtp = new SmtpClient();
        smtp.ServerCertificateValidationCallback = MySslCertificateValidationCallback!;
        smtp.Connect(_SmtpHost, _SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(_SmtpUser, _SmtpPass);
        await smtp.SendAsync(email);
        smtp.Disconnect(true);
    }

    public async Task SendPasswordResetLinkAsync(ApplicationUser user, string _email, string resetLink)
    {
        var _EmailFrom = configuration.GetSection("SmtpSettings:From").Value;
        var _SmtpHost = configuration.GetSection("SmtpSettings:Host").Value;
        var value = configuration.GetSection("SmtpSettings:Port").Value;
        int _SmtpPort = Convert.ToInt32(value);
        var _SmtpUser = configuration.GetSection("SmtpSettings:Username").Value;
        var _SmtpPass = configuration.GetSection("SmtpSettings:Password").Value;

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        message.To.Add(new MailboxAddress("", _email));
        message.Subject = "Reset Link";
        BodyBuilder builder = new();
        // create message
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        email.To.Add(new MailboxAddress("", _email));
        email.Subject = "Confirmation Link";
        builder.HtmlBody = resetLink;
        email.Body = builder.ToMessageBody();

        // send email
        using var smtp = new SmtpClient();
        smtp.ServerCertificateValidationCallback = MySslCertificateValidationCallback!;
        smtp.Connect(_SmtpHost, _SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(_SmtpUser, _SmtpPass);
        await smtp.SendAsync(email);
        smtp.Disconnect(true);
    }

    public async Task SendPasswordResetCodeAsync(ApplicationUser user, string _email, string resetCode)
    {
        var _EmailFrom = configuration.GetSection("SmtpSettings:From").Value;
        var _SmtpHost = configuration.GetSection("SmtpSettings:Host").Value;
        var value = configuration.GetSection("SmtpSettings:Port").Value;
        int _SmtpPort = Convert.ToInt32(value);
        var _SmtpUser = configuration.GetSection("SmtpSettings:Username").Value;
        var _SmtpPass = configuration.GetSection("SmtpSettings:Password").Value;

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        message.To.Add(new MailboxAddress("", _email));
        message.Subject = "Reset Code";
        BodyBuilder builder = new();
        // create message
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress("Administrator", _EmailFrom));
        email.To.Add(new MailboxAddress("", _email));
        email.Subject = "Confirmation Link";
        builder.HtmlBody = resetCode;
        email.Body = builder.ToMessageBody();

        // send email
        using var smtp = new SmtpClient();
        smtp.ServerCertificateValidationCallback = MySslCertificateValidationCallback!;
        smtp.Connect(_SmtpHost, _SmtpPort, SecureSocketOptions.StartTls);
        smtp.Authenticate(_SmtpUser, _SmtpPass);
        await smtp.SendAsync(email);
        smtp.Disconnect(true);
    }
}