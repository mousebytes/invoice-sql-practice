using Models;

public interface ICustomerRepo
{
    public Customer AddAsync(Customer model);
    public Customer GetAsync(int PK);
    public List<Customer> GetAllAsync();
    public Customer UpdateAsync(int PK, Customer model);
    public bool DeleteAsync(int PK);
}