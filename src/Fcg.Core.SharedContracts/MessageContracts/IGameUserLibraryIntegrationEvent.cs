using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameUserLibraryIntegrationEvent : IEvent
    {
        Guid UserId { get; }    
        Guid GameId { get; }
        string Name { get; }
        bool IsAvaiable { get; }
        string Description { get; }
        string Genre { get; }
        DateTime OccurredAt { get; }
    }
}
