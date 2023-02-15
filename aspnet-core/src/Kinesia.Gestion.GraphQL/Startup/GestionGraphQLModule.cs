using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion.Startup
{
    [DependsOn(typeof(GestionCoreModule))]
    public class GestionGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}