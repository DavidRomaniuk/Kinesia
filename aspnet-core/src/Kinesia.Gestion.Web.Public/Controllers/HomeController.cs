using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Web.Controllers;

namespace Kinesia.Gestion.Web.Public.Controllers
{
    public class HomeController : GestionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}