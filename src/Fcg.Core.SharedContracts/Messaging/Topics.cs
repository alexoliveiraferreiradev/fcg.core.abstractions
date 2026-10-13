namespace Fcg.Core.SharedContracts.Messaging
{
    public static class Topics
    {
        public const string UserCreated = "user-created";
        public const string UserRepublished = "user-republished";
        public const string UserDeactivated = "user-deactivated";
        public const string UserReactivated = "user-reactivated";
        public const string GameCreated = "game-created";
        public const string GameDeactivated = "game-deactivated";
        public const string GameReactivated = "game-reactivated";
        public const string GameUserLibrary = "game-user-library";
        public const string OrderPlaced = "order-placed";
        public const string PaymentApproved = "payment-approved";
        public const string PurchaseRejected = "purchase-rejected";
        public const string DeliveryFailed = "delivery-failed";

        // Subscription da notification em cada tópico
        public const string NotificationSubscription = "notification";
    }
}
