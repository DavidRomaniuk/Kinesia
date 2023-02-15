using Abp.Domain.Services;

namespace Kinesia.Gestion
{
    public abstract class GestionDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected GestionDomainServiceBase()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}
