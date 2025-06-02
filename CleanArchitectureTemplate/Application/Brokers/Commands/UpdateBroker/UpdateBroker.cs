using Application.Common.Interfaces;
using MediatR;
using Domain.Entities;
using Domain.Events;

namespace Application.Brokers.Commands.UpdateBroker;

public record UpdateBrokerCommand : IRequest
{
    public int Id { get; init; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public class UpdateBrokerCommandHandler : IRequestHandler<UpdateBrokerCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateBrokerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateBrokerCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Brokers.FindAsync(new object[] { request.Id }, cancellationToken);

        Guard.Against.NotFound(request.Id, entity);

        entity.FirstName = request.FirstName;
        entity.LastName = request.LastName;

        entity.AddDomainEvent(new BrokerUpdatedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);
    }
}
