using Models;
using Models.ViewModels;

public interface IInvoiceItemRepo
{
    public Task<InvoiceItemView> AddAsync(InvoiceItem model);
    public Task<InvoiceItemView?> GetAsync(int PK);
    public Task<IEnumerable<InvoiceItemView>> GetAllAsync();
    public Task<InvoiceItemView> UpdateAsync(InvoiceItem model);
    public Task<bool> DeleteAsync(int PK);
}