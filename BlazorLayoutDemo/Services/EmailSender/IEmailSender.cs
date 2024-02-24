
namespace BlazorLayoutDemo.Services
{
    public interface IEmailSender<TUser> where TUser : class
    {        
        Task SendConfirmationLinkAsync(TUser user, string email, string confirmationLink);
                
        Task SendPasswordResetLinkAsync(TUser user, string email, string resetLink);
                
        Task SendPasswordResetCodeAsync(TUser user, string email, string resetCode);

        Task SendEmailAsync(string to, string subject, string body, string? from = null);
        Task SendMessageAsync(string name, string from, string subject, string body);
    }
}