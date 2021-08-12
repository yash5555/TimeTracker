using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using TimeTracking.Authorization.Users;
using TimeTracking.MultiTenancy;

namespace TimeTracking.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}