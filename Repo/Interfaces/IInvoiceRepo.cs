using Models;

public interface IInvoiceRepo
{
    public Invoice AddAsync(Invoice model);
    public Invoice GetAsync(int PK);
    public List<Invoice> GetAllAsync();
    public Invoice UpdateAsync(int PK, Invoice model);
    public bool DeleteAsync(int PK);
}