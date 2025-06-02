﻿using Domain.Entities;

namespace Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Broker> Brokers { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
