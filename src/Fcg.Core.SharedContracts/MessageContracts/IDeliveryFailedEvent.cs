using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IDeliveryFailedEvent : IEvent
    {
        Guid OrderId { get; }
        Guid UserId { get; }
        string Reason { get; }
    }
}
