using Abp.AspNetCore.Mvc.Views;

namespace TimeTracking.Web.Views
{
    public abstract class TimeTrackingRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TimeTrackingRazorPage()
        {
            LocalizationSourceName = TimeTrackingConsts.LocalizationSourceName;
        }
    }
}
