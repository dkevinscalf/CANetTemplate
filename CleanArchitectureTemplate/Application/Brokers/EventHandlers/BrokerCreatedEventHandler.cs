using Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Brokers.EventHandlers;

public class BrokerCreatedEventHandler : INotificationHandler<BrokerCreatedEvent>
{
    private readonly ILogger<BrokerCreatedEventHandler> _logger;

    public BrokerCreatedEventHandler(ILogger<BrokerCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(BrokerCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanArchitectureTest Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
