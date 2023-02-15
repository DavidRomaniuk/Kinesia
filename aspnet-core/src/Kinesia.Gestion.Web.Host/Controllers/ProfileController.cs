using Abp.AspNetCore.Mvc.Authorization;
using Kinesia.Gestion.Authorization.Users.Profile;
using Kinesia.Gestion.Graphics;
using Kinesia.Gestion.Storage;

namespace Kinesia.Gestion.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageFormatValidator imageFormatValidator) :
            base(tempFileCacheManager, profileAppService, imageFormatValidator)
        {
        }
    }
}