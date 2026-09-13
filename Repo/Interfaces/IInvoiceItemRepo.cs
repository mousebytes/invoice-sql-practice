using Models;
using Models.ViewModels;

public interface IInvoiceItemRepo
{
    public InvoiceItemView Add(int PK);
    public InvoiceItemView Get(int PK);
    public List<InvoiceItemView> GetAll();
    public InvoiceItemView Update(int PK, InvoiceItem model);
    public bool Delete(int PK);
}