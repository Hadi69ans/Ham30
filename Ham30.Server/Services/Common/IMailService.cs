
using System.Threading.Tasks;

namespace Ham30.Server.Services.Common
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}