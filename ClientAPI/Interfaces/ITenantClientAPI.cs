using Models;

public interface ITenantClientAPI
{
    public Task<Tenant> AddAsync(Tenant model);
    public Task<Tenant?> GetAsync(int PK);
    public Task<IEnumerable<Tenant>> GetAllAsync();
    public Task<Tenant> UpdateAsync(Tenant model);
    public Task<bool> DeleteAsync(int PK);
}