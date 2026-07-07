namespace Fcg.Core.Abstractions.MessageContracts
{
    public record DeliveryFailedEvent(
        Guid OrderId, 
        Guid UserId, 
        string Reason);
}
