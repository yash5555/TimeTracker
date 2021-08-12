using System.Threading.Tasks;
using Abp.Webhooks;

namespace TimeTracking.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
