using Models;

public interface ICustomerRepo
{
    public Customer Add(int PK);
    public Customer Get(int PK);
    public List<Customer> GetAll();
    public Customer Update(int PK, Customer model);
    public bool Delete(int PK);
}