using System.Data;
using Microsoft.Data.SqlClient;

namespace Repo.Context;

public class RepoContext : IDbContext, IDisposable
{
    private readonly string _connectionString;
    private IDbConnection? _connection;
    private IDbTransaction? _transaction;

    public RepoContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection GetConnection()
    {
        if(_connection == null)
        {
            _connection = new SqlConnection(_connectionString);
        }

        if(_connection!.State != ConnectionState.Open)
        {
            _connection.Open();
        }

        return _connection;
    }

    public IDbTransaction? GetTransaction()
    {
        return _transaction;
    }

    public void BeginTransaction()
    {
        if(_transaction != null) return;

        var conn = GetConnection();
        _transaction = conn.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _transaction?.Commit();
        _transaction?.Dispose();
        _transaction = null;
    }

    public void RollbackTransaction()
    {
        _transaction?.Rollback();
        _transaction?.Dispose();
        _transaction = null;
    }

    public void Dispose()
    {
        _transaction?.Dispose();
        _connection?.Dispose();
    }
}