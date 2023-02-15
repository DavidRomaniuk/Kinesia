using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Kinesia.Gestion
{
    public class GestionClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionClientModule).GetAssembly());
        }
    }
}
