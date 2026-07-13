using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public record UserCreatedEvent(
        Guid UserId,
        string Name,
        string Email) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
