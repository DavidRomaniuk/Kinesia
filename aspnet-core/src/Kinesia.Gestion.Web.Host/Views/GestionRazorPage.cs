using Abp.AspNetCore.Mvc.Views;

namespace Kinesia.Gestion.Web.Views
{
    public abstract class GestionRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected GestionRazorPage()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}
