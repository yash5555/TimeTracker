using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.Install.Dto;

namespace TimeTracking.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}