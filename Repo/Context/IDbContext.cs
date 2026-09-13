using System.Data;

namespace Repo.Context;
public interface IDbContext
{
    IDbConnection GetConnection();
    IDbTransaction? GetTransaction();
    
    void BeginTransaction();
    void CommitTransaction();
    void RollbackTransaction();
}