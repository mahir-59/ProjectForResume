using Microsoft.Extensions.Configuration;

namespace ProjectForResume.Connection
{
    public class SqlServerConnection
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public string ConnectionString => _connectionString;
        public SqlServerConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlServer");
        }
    }
}
