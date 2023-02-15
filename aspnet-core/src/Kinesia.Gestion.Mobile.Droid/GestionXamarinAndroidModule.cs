using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion
{
    [DependsOn(typeof(GestionXamarinSharedModule))]
    public class GestionXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionXamarinAndroidModule).GetAssembly());
        }
    }
}