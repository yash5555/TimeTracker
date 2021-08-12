using System.Threading.Tasks;
using Abp.Application.Services;
using TimeTracking.Sessions.Dto;

namespace TimeTracking.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
