using Domain.Entities;

namespace Domain.Events;

public class BrokerUpdatedEvent : BaseEvent
{
    public BrokerUpdatedEvent(Broker broker)
    {
        Broker = broker;
    }

    public Broker Broker { get; }
}
