using Models;
using Models.ViewModels;

public interface IInvoiceItemRepo
{
    public InvoiceItemView AddAsync(InvoiceItem model);
    public InvoiceItemView GetAsync(int PK);
    public List<InvoiceItemView> GetAllAsync();
    public InvoiceItemView UpdateAsync(int PK, InvoiceItem model);
    public bool DeleteAsync(int PK);
}