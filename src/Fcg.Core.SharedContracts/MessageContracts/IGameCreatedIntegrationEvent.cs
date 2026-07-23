using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IGameCreatedIntegrationEvent : IEvent
    {
        Guid GameId { get; }
        string Name { get; }
        decimal Price { get; }
        bool IsAvaiable { get; }
        string Description { get; }
        string Genre { get; }   
        DateTime OccurredAt { get; }    
    }
}
