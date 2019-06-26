using Abp.Authorization;
using NetCoreAbp.Authorization.Roles;
using NetCoreAbp.Authorization.Users;

namespace NetCoreAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
