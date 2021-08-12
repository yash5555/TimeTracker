using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using TimeTracking.EntityFrameworkCore;

namespace TimeTracking.HealthChecks
{
    public class TimeTrackingDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public TimeTrackingDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("TimeTrackingDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("TimeTrackingDbContext could not connect to database"));
        }
    }
}
