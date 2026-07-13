using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public record OrderPlacedEvent(
     Guid OrderId,
     Guid UserId,
     IEnumerable<Guid> GameIds,
     decimal AmountPrice) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
