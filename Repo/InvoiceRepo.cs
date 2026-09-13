using Dapper;
using Models;
using Repo.Context;
namespace Repo;

public class InvoiceRepo : BaseRepo, IInvoiceRepo
{
    private const string _DatabaseAndSchema = "[InvoiceApp].[dbo].";
    public InvoiceRepo(IDbContext context) : base(context) {}

    public async Task<Invoice> AddAsync(Invoice model)
    {
        string procedure = _DatabaseAndSchema + "spInvoice_Add";
        var parameters = model;
        Invoice result = await Connection.QuerySingleAsync<Invoice>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spInvoice_Delete";
        var parameters = new {PK_Invoice = PK};
        bool result = await Connection.QuerySingleAsync<bool>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Invoice?> GetAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spInvoice_Get";
        var parameters = new {PK_Invoice = PK};
        Invoice? result = await Connection.QuerySingleOrDefaultAsync<Invoice>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<IEnumerable<Invoice>> GetAllAsync()
    {
        string procedure = _DatabaseAndSchema + "spInvoice_GetAll";
        var parameters = new {};
        IEnumerable<Invoice>? result = await Connection.QueryAsync<Invoice>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Invoice> UpdateAsync(Invoice model)
    {
        string procedure = _DatabaseAndSchema + "spInvoice_Update";
        var parameters = model;
        Invoice result = await Connection.QuerySingleAsync<Invoice>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }
}