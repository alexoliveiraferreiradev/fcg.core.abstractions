namespace Fcg.Core.WebApi.MessageBroker
{
    public class RabbitMqConnectionSettings
    {
        public string Host { get; set; } = string.Empty;
        public ushort Port { get; set; } = 5672;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public const string SectionName = "RabbitMqSettings";
    }
}
