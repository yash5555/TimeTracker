using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking
{
    [DependsOn(typeof(TimeTrackingClientModule), typeof(AbpAutoMapperModule))]
    public class TimeTrackingXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingXamarinSharedModule).GetAssembly());
        }
    }
}