using Abp.AutoMapper;
using Kinesia.Gestion.Organizations.Dto;

namespace Kinesia.Gestion.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}
