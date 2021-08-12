using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TimeTracking.Startup
{
    [DependsOn(typeof(TimeTrackingCoreModule))]
    public class TimeTrackingGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}