using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    [DependsOn(typeof(TimeTrackingCoreSharedModule))]
    public class TimeTrackingApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingApplicationSharedModule).GetAssembly());
        }
    }
}