using Kinesia.Gestion.Editions;
using Kinesia.Gestion.Editions.Dto;
using Kinesia.Gestion.MultiTenancy.Payments;
using Kinesia.Gestion.Security;
using Kinesia.Gestion.MultiTenancy.Payments.Dto;

namespace Kinesia.Gestion.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
