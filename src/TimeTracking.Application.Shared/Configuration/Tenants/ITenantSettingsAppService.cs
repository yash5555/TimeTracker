using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.Configuration.Tenants.Dto;

namespace TimeTracking.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
