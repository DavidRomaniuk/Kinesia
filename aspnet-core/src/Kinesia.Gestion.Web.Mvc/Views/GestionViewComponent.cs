using Abp.AspNetCore.Mvc.ViewComponents;

namespace Kinesia.Gestion.Web.Views
{
    public abstract class GestionViewComponent : AbpViewComponent
    {
        protected GestionViewComponent()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}