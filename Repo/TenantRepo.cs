using Dapper;
using Models;
using Repo.Context;
namespace Repo;

public class TenantRepo : BaseRepo, ITenantRepo
{
    private const string _DatabaseAndSchema = "[InvoiceApp].[dbo].";
    public TenantRepo(IDbContext context) : base(context) {}

    public async Task<Tenant> AddAsync(Tenant model)
    {
        string procedure = _DatabaseAndSchema + "spTenant_Add";
        var parameters = model;
        Tenant result = await Connection.QuerySingleAsync<Tenant>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spTenant_Delete";
        var parameters = new {PK_Tenant = PK};
        bool result = await Connection.QuerySingleAsync<bool>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Tenant> GetAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spTenant_Get";
        var parameters = new {PK_Tenant = PK};
        Tenant result = await Connection.QuerySingleAsync<Tenant>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<IEnumerable<Tenant>> GetAllAsync()
    {
        string procedure = _DatabaseAndSchema + "spTenant_Get";
        var parameters = new {};
        IEnumerable<Tenant> result = await Connection.QueryAsync<Tenant>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Tenant> UpdateAsync(int PK, Tenant model)
    {
        string procedure = _DatabaseAndSchema + "spTenant_Get";
        var parameters = model;
        Tenant result = await Connection.QuerySingleAsync<Tenant>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }
}