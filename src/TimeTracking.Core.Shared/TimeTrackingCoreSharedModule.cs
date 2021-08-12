using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    public class TimeTrackingCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingCoreSharedModule).GetAssembly());
        }
    }
}