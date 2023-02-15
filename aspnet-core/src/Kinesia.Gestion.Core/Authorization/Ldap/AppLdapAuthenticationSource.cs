using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Kinesia.Gestion.Authorization.Users;
using Kinesia.Gestion.MultiTenancy;

namespace Kinesia.Gestion.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}