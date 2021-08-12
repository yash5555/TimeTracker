using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TimeTracking.Configure;
using TimeTracking.Startup;
using TimeTracking.Test.Base;

namespace TimeTracking.GraphQL.Tests
{
    [DependsOn(
        typeof(TimeTrackingGraphQLModule),
        typeof(TimeTrackingTestBaseModule))]
    public class TimeTrackingGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimeTrackingGraphQLTestModule).GetAssembly());
        }
    }
}