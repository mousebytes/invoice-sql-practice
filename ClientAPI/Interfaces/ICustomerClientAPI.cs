using Models;

public interface ICustomerClientAPI
{
    public Task<Customer> AddAsync(Customer model);
    public Task<Customer?> GetAsync(int PK);
    public Task<IEnumerable<Customer>> GetAllAsync();
    public Task<Customer> UpdateAsync(Customer model);
    public Task<bool> DeleteAsync(int PK);
}