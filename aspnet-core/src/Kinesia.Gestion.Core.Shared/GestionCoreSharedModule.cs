using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion
{
    public class GestionCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionCoreSharedModule).GetAssembly());
        }
    }
}