using Fcg.Core.SharedContracts.Interfaces;

namespace Fcg.Core.SharedContracts.MessageContracts
{
    public interface IUserCreatedIntegrationEvent : IEvent
    {
        Guid UserId { get;}
        string Name { get;}
        string Email { get;}
    }
}
