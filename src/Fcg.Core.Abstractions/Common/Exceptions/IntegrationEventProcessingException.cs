namespace Fcg.Core.Abstractions.Common.Exceptions
{
    public class IntegrationEventProcessingException : Exception
    {
        /// <summary>
        /// Cria instância de IntegrationEventProcessingException com mensagem personalizada
        /// </summary>
        /// <param name="message"></param>
        public IntegrationEventProcessingException(string message) : base(message) { }
    }
}
