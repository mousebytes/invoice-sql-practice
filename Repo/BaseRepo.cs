using System.Data;
using Microsoft.Data.SqlClient;

namespace Repo;
public abstract class BaseRepo
{
    private string _connection;
    public BaseRepo(string connectionString)
    {
        _connection = connectionString;
    }

    protected IDbConnection CreateConnection()
    {
        return new SqlConnection(_connection);
    }
}