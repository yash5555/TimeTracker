using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TimeTracking.Common.Dto;
using TimeTracking.Editions.Dto;

namespace TimeTracking.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}