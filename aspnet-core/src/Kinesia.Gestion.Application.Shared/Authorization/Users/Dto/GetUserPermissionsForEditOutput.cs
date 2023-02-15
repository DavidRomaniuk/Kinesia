using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Permissions.Dto;

namespace Kinesia.Gestion.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}