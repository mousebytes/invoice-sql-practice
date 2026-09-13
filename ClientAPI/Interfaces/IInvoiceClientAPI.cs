using Models;

public interface IInvoiceClientAPI
{
    public Task<Invoice> AddAsync(Invoice model);
    public Task<Invoice?> GetAsync(int PK);
    public Task<IEnumerable<Invoice>> GetAllAsync();
    public Task<Invoice> UpdateAsync(Invoice model);
    public Task<bool> DeleteAsync(int PK);
}