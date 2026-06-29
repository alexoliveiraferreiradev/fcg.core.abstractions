using Fcg.Core.Abstractions.Interfaces;

namespace Fcg.Core.Abstractions.MessageContracts
{
    public record OrderPlacedEvent(
     Guid OrderId,
     Guid UserId,
     IEnumerable<Guid> JogosIds,
     decimal PrecoTotal) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
