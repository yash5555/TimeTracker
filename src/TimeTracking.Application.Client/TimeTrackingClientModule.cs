using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    public class TimeTrackingClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingClientModule).GetAssembly());
        }
    }
}
