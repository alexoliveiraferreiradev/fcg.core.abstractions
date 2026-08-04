using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameReactiveIntegrationEvent : IEvent
    {
        Guid GameId { get; }
        DateTime OccurredAt { get; }
    }
}
