using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TimeTracking.Authorization.Permissions.Dto;

namespace TimeTracking.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
