using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion
{
    [DependsOn(typeof(GestionCoreSharedModule))]
    public class GestionApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionApplicationSharedModule).GetAssembly());
        }
    }
}