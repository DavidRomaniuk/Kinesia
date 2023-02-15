using Abp.AspNetCore.Mvc.Authorization;
using Kinesia.Gestion.Authorization;
using Kinesia.Gestion.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace Kinesia.Gestion.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}