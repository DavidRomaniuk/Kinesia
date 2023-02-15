using Abp.AutoMapper;
using Kinesia.Gestion.Organizations.Dto;

namespace Kinesia.Gestion.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}