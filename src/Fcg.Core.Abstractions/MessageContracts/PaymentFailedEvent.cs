namespace Fcg.Core.Abstractions.MessageContracts
{
    public record PaymentFailedEvent(
     Guid OrderId,
     Guid UserId,
     string Reason
 );
}
