using Abp.AspNetCore.Mvc.ViewComponents;

namespace TimeTracking.Web.Public.Views
{
    public abstract class TimeTrackingViewComponent : AbpViewComponent
    {
        protected TimeTrackingViewComponent()
        {
            LocalizationSourceName = TimeTrackingConsts.LocalizationSourceName;
        }
    }
}