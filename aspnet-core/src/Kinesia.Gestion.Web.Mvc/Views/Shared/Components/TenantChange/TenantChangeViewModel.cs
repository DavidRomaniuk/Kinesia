using Abp.AutoMapper;
using Kinesia.Gestion.Sessions.Dto;

namespace Kinesia.Gestion.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}