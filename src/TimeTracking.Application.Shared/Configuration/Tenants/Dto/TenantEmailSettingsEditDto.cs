using Abp.Auditing;
using TimeTracking.Configuration.Dto;

namespace TimeTracking.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}