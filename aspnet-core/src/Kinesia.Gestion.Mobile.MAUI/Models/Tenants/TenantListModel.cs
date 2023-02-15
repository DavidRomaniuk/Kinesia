using Abp.AutoMapper;
using Kinesia.Gestion.MultiTenancy.Dto;

namespace Kinesia.Gestion.Mobile.MAUI.Models.Tenants
{
    [AutoMapFrom(typeof(TenantListDto))]
    [AutoMapTo(typeof(TenantEditDto), typeof(CreateTenantInput))]
    public class TenantListModel : TenantListDto
    {
 
    }
}
