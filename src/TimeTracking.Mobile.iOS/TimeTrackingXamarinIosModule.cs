using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    [DependsOn(typeof(TimeTrackingXamarinSharedModule))]
    public class TimeTrackingXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingXamarinIosModule).GetAssembly());
        }
    }
}