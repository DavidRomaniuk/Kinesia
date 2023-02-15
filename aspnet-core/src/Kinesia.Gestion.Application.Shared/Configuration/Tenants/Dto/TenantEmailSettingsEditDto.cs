using Abp.Auditing;
using Kinesia.Gestion.Configuration.Dto;

namespace Kinesia.Gestion.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}