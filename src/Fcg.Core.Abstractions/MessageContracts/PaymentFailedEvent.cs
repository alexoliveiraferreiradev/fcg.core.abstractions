namespace Fcg.Core.Abstractions.MessageContracts
{
    public record PaymentFailedEvent(
     Guid OrderId,
     string Reason
 );
}
