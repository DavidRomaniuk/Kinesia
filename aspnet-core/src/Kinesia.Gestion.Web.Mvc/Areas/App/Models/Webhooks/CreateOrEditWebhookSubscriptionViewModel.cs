using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Kinesia.Gestion.WebHooks.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
