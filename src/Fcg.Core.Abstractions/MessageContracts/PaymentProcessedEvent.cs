using Fcg.Core.Abstractions.Enum;
using Fcg.Core.Abstractions.Interfaces;

namespace Fcg.Core.Abstractions.MessageContracts
{
    public record PaymentProcessedEvent(
    Guid OrderId,
    Guid UserId,
    IEnumerable<Guid> GameIds) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
