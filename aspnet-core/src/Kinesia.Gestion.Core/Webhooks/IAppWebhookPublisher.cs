using System.Threading.Tasks;
using Kinesia.Gestion.Authorization.Users;

namespace Kinesia.Gestion.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
