using Models;
namespace Repo;

public class InvoiceRepo : BaseRepo, IInvoiceRepo
{
    public InvoiceRepo(string connectionString) : base(connectionString) {}
    public Invoice Add(int PK)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int PK)
    {
        throw new NotImplementedException();
    }

    public Invoice Get(int PK)
    {
        throw new NotImplementedException();
    }

    public List<Invoice> GetAll()
    {
        throw new NotImplementedException();
    }

    public Invoice Update(int PK, Invoice model)
    {
        throw new NotImplementedException();
    }
}