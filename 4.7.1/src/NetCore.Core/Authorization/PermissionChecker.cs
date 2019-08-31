using Abp.Authorization;
using NetCore.Authorization.Roles;
using NetCore.Authorization.Users;

namespace NetCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
