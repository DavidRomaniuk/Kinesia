using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Kinesia.Gestion.Authorization;

namespace Kinesia.Gestion
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(GestionApplicationSharedModule),
        typeof(GestionCoreModule)
        )]
    public class GestionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionApplicationModule).GetAssembly());
        }
    }
}