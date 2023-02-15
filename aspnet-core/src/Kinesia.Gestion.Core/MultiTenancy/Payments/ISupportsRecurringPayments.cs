using Abp.Events.Bus.Handlers;

namespace Kinesia.Gestion.MultiTenancy.Payments
{
    public interface ISupportsRecurringPayments : 
        IEventHandler<RecurringPaymentsDisabledEventData>, 
        IEventHandler<RecurringPaymentsEnabledEventData>,
        IEventHandler<TenantEditionChangedEventData>
    {

    }
}
