using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Web.Controllers;

namespace Kinesia.Gestion.Web.Public.Controllers
{
    public class AboutController : GestionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}