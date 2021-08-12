using Microsoft.Extensions.Configuration;

namespace TimeTracking.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
