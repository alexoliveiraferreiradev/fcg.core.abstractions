using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace Fcg.Core.WebApi.Database
{
    public class DatabaseConnectionSettings
    {
        [Required(ErrorMessage = "Host do banco de dados é obrigatório.")]
        public string Host { get; set; } = string.Empty;
        [Required(ErrorMessage = "Porta do banco de dados é obrigatória.")]
        [Range(1, 65535, ErrorMessage = "Porta do banco de dados deve estar entre 1 e 65535.")]
        public int Port { get; set; } = 1433;
        [Required(ErrorMessage = "Nome de usuário é obrigatório.")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Nome do banco de dados é obrigatório.")]
        public string DatabaseName { get; set; } = string.Empty;

        public const string DatabaseSettingsSection = "DatabaseSettings";

        public string ToConnectionString() => new SqlConnectionStringBuilder
        {
            DataSource = $"{Host},{Port}",
            InitialCatalog = DatabaseName,
            UserID = Username,
            Password = Password,
            TrustServerCertificate = true,
            Encrypt = false
        }.ConnectionString;

    }
}
