using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.Authorization.Permissions.Dto;
using Kinesia.Gestion.Web.Areas.App.Models.Common;

namespace Kinesia.Gestion.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}