using Application.Common.Interfaces;
using MediatR;
using Domain.Entities;
using Domain.Events;

namespace Application.Brokers.Commands.CreateBroker;

public record CreateBrokerCommand : IRequest<int>
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public class CreateBrokerCommandHandler : IRequestHandler<CreateBrokerCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateBrokerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateBrokerCommand request, CancellationToken cancellationToken)
    {
        var entity = new Broker
        {
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        entity.AddDomainEvent(new BrokerCreatedEvent(entity));

        _context.Brokers.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
