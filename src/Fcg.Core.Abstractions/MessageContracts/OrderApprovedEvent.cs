using Fcg.Core.Abstractions.Interfaces;

namespace Fcg.Core.Abstractions.MessageContracts
{
    public record OrderApprovedEvent(
        Guid OrderId,
        Guid UserId,
        string EmailUsuario,
        string NomeUsuario,
        DateTime DataCompra) : IEvent
    {
        public Guid EventId { get; init; } = Guid.NewGuid();
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    }
}
