using Domain.Entities;

namespace Domain.Events;

public class BrokerCreatedEvent : BaseEvent
{
    public BrokerCreatedEvent(Broker broker)
    {
        Broker = broker;
    }

    public Broker Broker { get; }
}
