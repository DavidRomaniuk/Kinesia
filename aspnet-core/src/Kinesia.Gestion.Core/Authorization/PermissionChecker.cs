using Abp.Authorization;
using Kinesia.Gestion.Authorization.Roles;
using Kinesia.Gestion.Authorization.Users;

namespace Kinesia.Gestion.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
