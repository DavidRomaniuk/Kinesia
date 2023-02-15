using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Kinesia.Gestion.Web.Public.Views
{
    public abstract class GestionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected GestionRazorPage()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}
