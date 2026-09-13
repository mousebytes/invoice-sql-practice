using System.Data;
using Microsoft.Data.SqlClient;
using Repo.Context;

namespace Repo;
public abstract class BaseRepo
{
    protected readonly IDbContext Context;
    public BaseRepo(IDbContext context)
    {
        Context = context;
    }

    protected IDbConnection Connection => Context.GetConnection();
    protected IDbTransaction? Transaction => Context.GetTransaction();
}