using Models;
namespace Repo;

public class CustomerRepo : BaseRepo, ICustomerRepo
{
    public CustomerRepo(string connectionString) : base(connectionString) {}
    public Customer Add(int PK)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int PK)
    {
        throw new NotImplementedException();
    }

    public Customer Get(int PK)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer Update(int PK, Customer model)
    {
        throw new NotImplementedException();
    }
}