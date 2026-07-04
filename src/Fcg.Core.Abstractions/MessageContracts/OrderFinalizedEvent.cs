using Fcg.Core.Abstractions.Enum;
using Fcg.Core.Abstractions.Interfaces;

namespace Fcg.Core.Abstractions.MessageContracts
{
    public record OrderFinalizedEvent(
    Guid OrderId,
    Guid UserId,
    string EmailUsuario,
    string NomeUsuario,
    IEnumerable<Guid> JogosIds,
    PaymentStatus Status) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
