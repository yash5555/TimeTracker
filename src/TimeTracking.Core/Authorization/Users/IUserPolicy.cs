using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace TimeTracking.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
