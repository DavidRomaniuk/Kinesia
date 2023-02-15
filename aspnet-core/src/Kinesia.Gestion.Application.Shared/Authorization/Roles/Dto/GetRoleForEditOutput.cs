using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Permissions.Dto;

namespace Kinesia.Gestion.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}