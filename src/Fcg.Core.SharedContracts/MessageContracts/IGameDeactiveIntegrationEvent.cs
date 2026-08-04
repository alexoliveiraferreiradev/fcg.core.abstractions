using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameDeactiveIntegrationEvent : IEvent
    {
        Guid GameId { get; }
        DateTime OccurredAt { get; }
    }
}
