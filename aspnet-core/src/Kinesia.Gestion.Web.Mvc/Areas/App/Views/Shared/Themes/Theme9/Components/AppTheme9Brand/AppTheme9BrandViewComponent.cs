﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Web.Areas.App.Models.Layout;
using Kinesia.Gestion.Web.Session;
using Kinesia.Gestion.Web.Views;

namespace Kinesia.Gestion.Web.Areas.App.Views.Shared.Themes.Theme9.Components.AppTheme9Brand
{
    public class AppTheme9BrandViewComponent : GestionViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppTheme9BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
