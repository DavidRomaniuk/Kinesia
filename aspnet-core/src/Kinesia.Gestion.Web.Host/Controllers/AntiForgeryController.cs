using Microsoft.AspNetCore.Antiforgery;

namespace Kinesia.Gestion.Web.Controllers
{
    public class AntiForgeryController : GestionControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
