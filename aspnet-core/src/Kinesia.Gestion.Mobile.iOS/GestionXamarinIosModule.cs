using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion
{
    [DependsOn(typeof(GestionXamarinSharedModule))]
    public class GestionXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionXamarinIosModule).GetAssembly());
        }
    }
}