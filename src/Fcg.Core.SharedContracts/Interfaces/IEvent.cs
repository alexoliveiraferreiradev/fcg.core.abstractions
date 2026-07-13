namespace Fcg.Core.SharedContracts.Interfaces
{
    public interface IEvent
    {
        Guid EventId { get; }
        DateTime CreatedAt { get; }
    }
}
