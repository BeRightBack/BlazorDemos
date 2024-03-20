
using BlazorIdentityDemo.Entity;

namespace BlazorIdentityDemo.Services
{
    public interface IEmailSender
    {        
        Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink);
                
        Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink);
                
        Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode);

        Task SendEmailAsync(string to, string subject, string body, string? from = null);
        Task SendMessageAsync(string name, string from, string subject, string body);
    }
}