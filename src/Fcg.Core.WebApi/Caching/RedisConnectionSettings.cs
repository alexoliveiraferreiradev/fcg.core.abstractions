using System.ComponentModel.DataAnnotations;

namespace Fcg.Core.WebApi.Caching
{
    public class RedisConnectionSettings
    {
        [Required(ErrorMessage = "Host do Redis é obrigatório.")]
        public string Host { get; set; } = string.Empty;     
        [Range(1, 65535, ErrorMessage = "Porta do Redis deve estar entre 1 e 65535.")]
        public int Port { get; set; } = 6379;
        [Required(ErrorMessage = "Senha do Redis é obrigatória.")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Nome da instância do Redis é obrigatório.")]
        public string InstanceName { get; set; } = string.Empty;
        public int ExpirationInSeconds { get; set; } = 0; 
        public int ExpirationInDays { get; set; } = 0; 
        public int ExpirationInHours { get; set; } = 0;

        public const string RedisSectionName = "RedisSettings";
    }
}
