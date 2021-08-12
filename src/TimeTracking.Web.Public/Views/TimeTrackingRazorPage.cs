using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace TimeTracking.Web.Public.Views
{
    public abstract class TimeTrackingRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TimeTrackingRazorPage()
        {
            LocalizationSourceName = TimeTrackingConsts.LocalizationSourceName;
        }
    }
}
