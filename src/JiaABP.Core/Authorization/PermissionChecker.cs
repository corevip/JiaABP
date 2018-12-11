using Abp.Authorization;
using JiaABP.Authorization.Roles;
using JiaABP.Authorization.Users;

namespace JiaABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
