using System.Collections.Generic;
using Kinesia.Gestion.Authorization.Permissions.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}