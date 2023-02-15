using Abp.AutoMapper;
using Kinesia.Gestion.Authorization.Roles.Dto;
using Kinesia.Gestion.Web.Areas.App.Models.Common;

namespace Kinesia.Gestion.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}