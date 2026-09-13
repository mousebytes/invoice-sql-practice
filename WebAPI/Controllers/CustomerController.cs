using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers;

public class CustomerController : BaseController
{
    ICustomerRepo _repo;

    public CustomerController(ICustomerRepo repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public async Task<Customer> AddAsync([FromBody] Customer model)
    {
        return await _repo.AddAsync(model);
    }

    [HttpGet("{PK}")]
    public async Task<Customer?> GetAsync(int PK)
    {
        return await _repo.GetAsync(PK);
    }

    [HttpGet]
    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    [HttpPut]
    public async Task<Customer> UpdateAsync([FromBody] Customer model)
    {
        return await _repo.UpdateAsync(model);
    }

    [HttpDelete("{PK}")]
    public async Task<bool> DeleteAsync(int PK)
    {
        return await _repo.DeleteAsync(PK);
    }
}