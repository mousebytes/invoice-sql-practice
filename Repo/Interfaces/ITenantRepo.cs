using Models;

public interface ITenantRepo
{
    public Tenant Add(int PK);
    public Tenant Get(int PK);
    public List<Tenant> GetAll();
    public Tenant Update(int PK, Tenant model);
    public bool Delete(int PK);
}