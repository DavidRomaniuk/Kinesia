using Abp;

namespace Kinesia.Gestion
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="GestionDomainServiceBase"/>.
    /// For application services inherit GestionAppServiceBase.
    /// </summary>
    public abstract class GestionServiceBase : AbpServiceBase
    {
        protected GestionServiceBase()
        {
            LocalizationSourceName = GestionConsts.LocalizationSourceName;
        }
    }
}