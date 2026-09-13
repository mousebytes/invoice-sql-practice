using Dapper;
using Models;
using Models.ViewModels;
using Repo.Context;
namespace Repo;

public class InvoiceItemRepo : BaseRepo, IInvoiceItemRepo
{
    private const string _DatabaseAndSchema = "[InvoiceApp].[dbo].";
    public InvoiceItemRepo(IDbContext context) : base(context) {}

    public async Task<InvoiceItemView> AddAsync(InvoiceItem model)
    {
        string procedure = _DatabaseAndSchema + "spInvoiceItem_Add";
        var parameters = model;
        InvoiceItemView result = await Connection.QuerySingleAsync<InvoiceItemView>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spInvoiceItem_Delete";
        var parameters = new {PK_InvoiceItemView = PK};
        bool result = await Connection.QuerySingleAsync<bool>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<InvoiceItemView?> GetAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spInvoiceItem_Get";
        var parameters = new {PK_InvoiceItemView = PK};
        InvoiceItemView? result = await Connection.QuerySingleOrDefaultAsync<InvoiceItemView>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<IEnumerable<InvoiceItemView>> GetAllAsync()
    {
        string procedure = _DatabaseAndSchema + "spInvoiceItem_GetAll";
        var parameters = new {};
        IEnumerable<InvoiceItemView>? result = await Connection.QueryAsync<InvoiceItemView>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<InvoiceItemView> UpdateAsync(InvoiceItem model)
    {
        string procedure = _DatabaseAndSchema + "spInvoiceItem_Update";
        var parameters = model;
        InvoiceItemView result = await Connection.QuerySingleAsync<InvoiceItemView>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }
}