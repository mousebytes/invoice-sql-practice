using Models;
namespace Repo;

public class TenantRepo : BaseRepo, ITenantRepo
{
    public TenantRepo(string connectionString) : base(connectionString) {}

    public Tenant Add(int PK)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int PK)
    {
        throw new NotImplementedException();
    }

    public Tenant Get(int PK)
    {
        throw new NotImplementedException();
    }

    public List<Tenant> GetAll()
    {
        throw new NotImplementedException();
    }

    public Tenant Update(int PK, Tenant model)
    {
        throw new NotImplementedException();
    }
}