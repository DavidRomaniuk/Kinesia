using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.Install.Dto;

namespace Kinesia.Gestion.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}