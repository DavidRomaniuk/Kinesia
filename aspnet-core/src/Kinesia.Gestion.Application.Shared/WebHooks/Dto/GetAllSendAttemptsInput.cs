using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
