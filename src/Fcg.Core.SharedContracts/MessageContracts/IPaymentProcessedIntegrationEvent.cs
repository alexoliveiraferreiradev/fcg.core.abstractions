using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IPaymentProcessedIntegrationEvent : IEvent
    {
        Guid OrderId { get; }
        Guid UserId { get; }
        IEnumerable<Guid> GameIds { get; }
    }
}
