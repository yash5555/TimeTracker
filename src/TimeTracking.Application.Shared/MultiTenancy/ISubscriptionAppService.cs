using System.Threading.Tasks;
using Abp.Application.Services;

namespace TimeTracking.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
