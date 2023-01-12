using System;

namespace Core.Aggregates;

public abstract class Aggregate : Aggregate<Guid>, IAggregate
{
}

public abstract class Aggregate<T> : IAggregate<T> where T : notnull
{
    public T Id { get; protected set; } = default!;
    
    public int Version { get; protected set; }
    
    public void When(object @event)
    {
        throw new NotImplementedException();
    }
    
    public object[] DequeueUncommittedEvents()
    {
        throw new NotImplementedException();
    }
}
