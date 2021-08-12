using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    [DependsOn(typeof(TimeTrackingXamarinSharedModule))]
    public class TimeTrackingXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingXamarinAndroidModule).GetAssembly());
        }
    }
}