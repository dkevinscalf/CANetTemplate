using Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Brokers.EventHandlers;

public class BrokerUpdatedEventHandler : INotificationHandler<BrokerUpdatedEvent>
{
    private readonly ILogger<BrokerUpdatedEventHandler> _logger;

    public BrokerUpdatedEventHandler(ILogger<BrokerUpdatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(BrokerUpdatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanArchitectureTest Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
