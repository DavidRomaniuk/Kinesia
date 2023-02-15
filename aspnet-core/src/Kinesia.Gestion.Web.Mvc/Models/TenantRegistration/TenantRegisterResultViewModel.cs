using Abp.AutoMapper;
using Kinesia.Gestion.MultiTenancy.Dto;

namespace Kinesia.Gestion.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}