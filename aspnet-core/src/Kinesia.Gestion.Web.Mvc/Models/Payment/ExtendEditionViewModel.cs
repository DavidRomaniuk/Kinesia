using System.Collections.Generic;
using Kinesia.Gestion.Editions.Dto;
using Kinesia.Gestion.MultiTenancy.Payments;

namespace Kinesia.Gestion.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}