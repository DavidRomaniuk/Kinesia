using Abp.Application.Services;
using Kinesia.Gestion.Dto;
using Kinesia.Gestion.Logging.Dto;

namespace Kinesia.Gestion.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
