using Abp.Application.Services.Dto;

namespace Kinesia.Gestion.Notifications.Dto
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}