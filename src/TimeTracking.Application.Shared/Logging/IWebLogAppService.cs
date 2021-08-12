using Abp.Application.Services;
using TimeTracking.Dto;
using TimeTracking.Logging.Dto;

namespace TimeTracking.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
