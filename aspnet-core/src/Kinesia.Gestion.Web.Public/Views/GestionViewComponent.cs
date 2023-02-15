using Abp.AspNetCore.Mvc.ViewComponents;

namespace Kinesia.Gestion.Web.Public.Views
{
    public abstract class GestionViewComponent : AbpViewComponent
    {
        protected GestionViewComponent()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}