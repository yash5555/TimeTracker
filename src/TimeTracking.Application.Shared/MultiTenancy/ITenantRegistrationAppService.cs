using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.Editions.Dto;
using TimeTracking.MultiTenancy.Dto;

namespace TimeTracking.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}