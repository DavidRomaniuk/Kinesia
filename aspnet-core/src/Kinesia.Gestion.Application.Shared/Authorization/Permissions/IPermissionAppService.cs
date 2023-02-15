using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.Authorization.Permissions.Dto;

namespace Kinesia.Gestion.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
