using Abp.Modules;
using TimeTracking.Test.Base;

namespace TimeTracking.Tests
{
    [DependsOn(typeof(TimeTrackingTestBaseModule))]
    public class TimeTrackingTestModule : AbpModule
    {
       
    }
}
