using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.Configuration.Host.Dto;

namespace Kinesia.Gestion.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
