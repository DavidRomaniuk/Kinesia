using Microsoft.Extensions.Configuration;

namespace Kinesia.Gestion.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
