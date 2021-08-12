using Abp.Authorization;
using TimeTracking.Authorization.Roles;
using TimeTracking.Authorization.Users;

namespace TimeTracking.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
