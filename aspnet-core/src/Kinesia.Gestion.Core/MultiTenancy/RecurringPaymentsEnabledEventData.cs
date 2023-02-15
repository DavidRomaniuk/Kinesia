using Abp.Events.Bus;

namespace Kinesia.Gestion.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}