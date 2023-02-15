using Kinesia.Gestion.Editions.Dto;

namespace Kinesia.Gestion.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < GestionConsts.MinimumUpgradePaymentAmount;
        }
    }
}
