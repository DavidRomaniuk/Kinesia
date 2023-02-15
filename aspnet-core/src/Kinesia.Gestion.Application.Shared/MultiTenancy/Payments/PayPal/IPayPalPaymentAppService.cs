using System.Threading.Tasks;
using Abp.Application.Services;
using Kinesia.Gestion.MultiTenancy.Payments.PayPal.Dto;

namespace Kinesia.Gestion.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
