using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGamePriceChangedIntegrationEvent : IEvent
    {
        Guid GameId { get; }
        decimal NewPrice { get; }
        DateTime OccurredAt { get; }
    }
}
