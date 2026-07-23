using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IOrderPlacedIntegrationEvent : IEvent
    {
        Guid OrderId { get; }
        Guid UserId { get; }
        IEnumerable<Guid> GameIds { get; }
        decimal AmountPrice { get; }
    }
}
