using System.Threading.Tasks;
using Abp.Authorization.Users;
using TimeTracking.Authorization.Users;

namespace TimeTracking.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
