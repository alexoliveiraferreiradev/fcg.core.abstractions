using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IUserReactivatedIntegrationEvent : IEvent
    {
        Guid UserId { get; }
    }
}
