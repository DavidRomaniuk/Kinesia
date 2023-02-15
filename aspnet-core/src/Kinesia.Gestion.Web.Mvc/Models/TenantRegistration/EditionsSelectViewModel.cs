using Abp.AutoMapper;
using Kinesia.Gestion.MultiTenancy.Dto;

namespace Kinesia.Gestion.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
