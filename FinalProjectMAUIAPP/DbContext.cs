using Microsoft.Extensions.Configuration;
using MySqlConnector;

public class DbContext
{
    private readonly IConfiguration _configuration;

    public DbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public MySqlConnection GetConnection()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");
        return new MySqlConnection(connectionString);
    }
}
