using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Kinesia.Gestion.Configuration;

namespace Kinesia.Gestion.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(GestionTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
