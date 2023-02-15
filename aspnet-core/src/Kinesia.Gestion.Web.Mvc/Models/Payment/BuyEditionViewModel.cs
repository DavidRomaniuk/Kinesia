using System.Collections.Generic;
using Kinesia.Gestion.Editions;
using Kinesia.Gestion.Editions.Dto;
using Kinesia.Gestion.MultiTenancy.Payments;
using Kinesia.Gestion.MultiTenancy.Payments.Dto;

namespace Kinesia.Gestion.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
