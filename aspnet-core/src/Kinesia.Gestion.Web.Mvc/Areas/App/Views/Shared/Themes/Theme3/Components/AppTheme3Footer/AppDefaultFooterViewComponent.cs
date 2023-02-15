using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Web.Areas.App.Models.Layout;
using Kinesia.Gestion.Web.Session;
using Kinesia.Gestion.Web.Views;

namespace Kinesia.Gestion.Web.Areas.App.Views.Shared.Themes.Theme3.Components.AppTheme3Footer
{
    public class AppTheme3FooterViewComponent : GestionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme3FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
