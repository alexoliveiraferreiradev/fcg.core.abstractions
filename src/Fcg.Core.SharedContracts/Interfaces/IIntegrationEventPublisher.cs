namespace Fcg.Core.SharedContracts.Interfaces
{
    public interface IIntegrationEventPublisher
    {
        Task PublishAsync<T>(object integrationEvent, CancellationToken cancellationToken = default) where T : class;
    }
}
