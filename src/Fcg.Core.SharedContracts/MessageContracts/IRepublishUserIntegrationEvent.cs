using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IRepublishUserIntegrationEvent : IEvent
    {
        Guid UserId { get; }

        string Name { get; }

        string Email { get; }
    }
}
