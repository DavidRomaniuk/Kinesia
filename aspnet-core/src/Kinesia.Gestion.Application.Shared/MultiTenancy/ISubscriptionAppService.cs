using System.Threading.Tasks;
using Abp.Application.Services;

namespace Kinesia.Gestion.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
