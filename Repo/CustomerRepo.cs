using Dapper;
using Models;
using Repo.Context;
namespace Repo;

public class CustomerRepo : BaseRepo, ICustomerRepo
{
    private const string _DatabaseAndSchema = "[InvoiceApp].[dbo].";
    public CustomerRepo(IDbContext context) : base(context) {}

    public async Task<Customer> AddAsync(Customer model)
    {
        string procedure = _DatabaseAndSchema + "spCustomer_Add";
        var parameters = model;
        Customer result = await Connection.QuerySingleAsync<Customer>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spCustomer_Delete";
        var parameters = new {PK_Customer = PK};
        bool result = await Connection.QuerySingleAsync<bool>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Customer?> GetAsync(int PK)
    {
        string procedure = _DatabaseAndSchema + "spCustomer_Get";
        var parameters = new {PK_Customer = PK};
        Customer? result = await Connection.QuerySingleOrDefaultAsync<Customer>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        string procedure = _DatabaseAndSchema + "spCustomer_GetAll";
        var parameters = new {};
        IEnumerable<Customer>? result = await Connection.QueryAsync<Customer>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }

    public async Task<Customer> UpdateAsync(Customer model)
    {
        string procedure = _DatabaseAndSchema + "spCustomer_Update";
        var parameters = model;
        Customer result = await Connection.QuerySingleAsync<Customer>(procedure, parameters, Transaction, commandType: System.Data.CommandType.StoredProcedure);
        return result;
    }
}