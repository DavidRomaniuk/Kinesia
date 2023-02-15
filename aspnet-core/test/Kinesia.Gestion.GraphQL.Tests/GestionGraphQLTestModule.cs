using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Kinesia.Gestion.Configure;
using Kinesia.Gestion.Startup;
using Kinesia.Gestion.Test.Base;

namespace Kinesia.Gestion.GraphQL.Tests
{
    [DependsOn(
        typeof(GestionGraphQLModule),
        typeof(GestionTestBaseModule))]
    public class GestionGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GestionGraphQLTestModule).GetAssembly());
        }
    }
}