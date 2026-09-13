using Models;
using Models.ViewModels;
namespace Repo;

public class InvoiceItemRepo : BaseRepo, IInvoiceItemRepo
{
    public InvoiceItemRepo(string connectionString) : base(connectionString) {}
    public InvoiceItemView Add(InvoiceItem model)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int PK)
    {
        throw new NotImplementedException();
    }

    public InvoiceItemView Get(int PK)
    {
        throw new NotImplementedException();
    }

    public List<InvoiceItemView> GetAll()
    {
        throw new NotImplementedException();
    }

    public InvoiceItemView Update(int PK, InvoiceItem model)
    {
        throw new NotImplementedException();
    }
}