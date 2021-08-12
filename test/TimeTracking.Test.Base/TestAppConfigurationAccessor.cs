using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using TimeTracking.Configuration;

namespace TimeTracking.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(TimeTrackingTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
