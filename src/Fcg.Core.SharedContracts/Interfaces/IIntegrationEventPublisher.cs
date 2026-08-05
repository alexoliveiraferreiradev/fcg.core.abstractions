namespace Fcg.Core.SharedContracts.Interfaces
{
    internal interface IIntegrationEventPublisher
    {
        Task PublishAsync<T>(object integrationEvent, CancellationToken cancellationToken = default) where T : class;
    }
}
