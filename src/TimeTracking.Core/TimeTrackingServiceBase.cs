using Abp;

namespace TimeTracking
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="TimeTrackingDomainServiceBase"/>.
    /// For application services inherit TimeTrackingAppServiceBase.
    /// </summary>
    public abstract class TimeTrackingServiceBase : AbpServiceBase
    {
        protected TimeTrackingServiceBase()
        {
            LocalizationSourceName = TimeTrackingConsts.LocalizationSourceName;
        }
    }
}