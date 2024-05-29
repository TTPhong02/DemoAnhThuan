using Abp.Authorization;
using SinglePageDemo.Authorization.Roles;
using SinglePageDemo.Authorization.Users;

namespace SinglePageDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
