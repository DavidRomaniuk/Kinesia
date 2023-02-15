using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.MultiTenancy.Payments.Dto;
using Kinesia.Gestion.MultiTenancy.Payments.Stripe.Dto;

namespace Kinesia.Gestion.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}