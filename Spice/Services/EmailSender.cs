using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Spice.Services
{
    public class EmailSender : IEmailSender
    {
        Task IEmailSender.SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}
