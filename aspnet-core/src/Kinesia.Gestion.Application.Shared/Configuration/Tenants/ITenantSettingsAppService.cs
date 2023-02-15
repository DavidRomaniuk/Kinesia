using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.Configuration.Tenants.Dto;

namespace Kinesia.Gestion.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
