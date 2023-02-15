using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Web.Controllers;

namespace Kinesia.Gestion.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class WelcomeController : GestionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}