

namespace cutontheruler_infra.context;
public class AggregateRoot : IAggregateRoot
{
    public Guid Id { get; init; }

    public AggregateRoot()
    {
        Id = Guid.NewGuid();    
    }
}
