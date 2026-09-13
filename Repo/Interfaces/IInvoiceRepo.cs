using Models;

public interface IInvoiceRepo
{
    public Invoice Add(int PK);
    public Invoice Get(int PK);
    public List<Invoice> GetAll();
    public Invoice Update(int PK, Invoice model);
    public bool Delete(int PK);
}