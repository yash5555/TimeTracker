using System.Threading.Tasks;
using TimeTracking.Sessions.Dto;

namespace TimeTracking.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
