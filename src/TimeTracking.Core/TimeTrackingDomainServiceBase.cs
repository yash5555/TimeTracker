using Abp.Domain.Services;

namespace TimeTracking
{
    public abstract class TimeTrackingDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected TimeTrackingDomainServiceBase()
        {
            LocalizationSourceName = TimeTrackingConsts.LocalizationSourceName;
        }
    }
}
