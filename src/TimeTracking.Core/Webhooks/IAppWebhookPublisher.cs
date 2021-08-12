using System.Threading.Tasks;
using TimeTracking.Authorization.Users;

namespace TimeTracking.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
