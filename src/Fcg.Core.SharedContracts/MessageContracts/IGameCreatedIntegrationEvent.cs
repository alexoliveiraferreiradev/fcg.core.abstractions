using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameCreatedIntegrationEvent : IEvent
    {
        Guid UserId { get; }
        Guid GamesIds { get; }
        string Name { get; }
        decimal Price { get; }
        string Description { get; }
    }
}
