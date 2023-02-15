using System.Threading.Tasks;
using Abp.Webhooks;

namespace Kinesia.Gestion.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
