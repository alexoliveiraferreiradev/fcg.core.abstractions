namespace Fcg.Core.Abstractions.Interfaces
{
    public interface IEvent
    {
        Guid EventId { get; }
        DateTime CreatedAt { get; }
    }
}
