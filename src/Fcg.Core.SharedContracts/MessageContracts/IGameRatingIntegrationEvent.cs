using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameRatingIntegrationEvent : IEvent
    {
        Guid GameId { get; }
        Guid UserId { get; }
        double Rating { get; }
        DateTime OccurredAt { get; }
    }
}
