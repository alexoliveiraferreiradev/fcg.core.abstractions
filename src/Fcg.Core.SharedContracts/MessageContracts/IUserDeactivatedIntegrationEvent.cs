using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IUserDeactivatedIntegrationEvent : IEvent
    {
        Guid UserId { get; }
    }
}
