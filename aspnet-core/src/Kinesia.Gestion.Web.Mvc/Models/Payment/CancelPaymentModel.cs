using Kinesia.Gestion.MultiTenancy.Payments;

namespace Kinesia.Gestion.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}