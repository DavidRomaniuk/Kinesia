using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Kinesia.Gestion.ApiClient;
using Kinesia.Gestion.Mobile.MAUI.Core.ApiClient;

namespace Kinesia.Gestion
{
    [DependsOn(typeof(GestionClientModule), typeof(AbpAutoMapperModule))]

    public class GestionMobileMAUIModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            Configuration.ReplaceService<IApplicationContext, MAUIApplicationContext>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionMobileMAUIModule).GetAssembly());
        }
    }
}