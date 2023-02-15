using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Kinesia.Gestion.Authorization;
using Kinesia.Gestion.DashboardCustomization;
using System.Threading.Tasks;
using Kinesia.Gestion.Web.Areas.App.Startup;

namespace Kinesia.Gestion.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(GestionDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}