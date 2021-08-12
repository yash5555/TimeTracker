using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TimeTracking.Authorization.Users.Dto;

namespace TimeTracking.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
