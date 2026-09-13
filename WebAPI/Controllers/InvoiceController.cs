using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers;

public class InvoiceController : BaseController
{
    IInvoiceRepo _repo;

    public InvoiceController(IInvoiceRepo repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public async Task<Invoice> AddAsync([FromBody] Invoice model)
    {
        return await _repo.AddAsync(model);
    }

    [HttpGet("{PK}")]
    public async Task<Invoice?> GetAsync(int PK)
    {
        return await _repo.GetAsync(PK);
    }

    [HttpGet]
    public async Task<IEnumerable<Invoice>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    [HttpPut]
    public async Task<Invoice> UpdateAsync([FromBody] Invoice model)
    {
        return await _repo.UpdateAsync(model);
    }

    [HttpDelete("{PK}")]
    public async Task<bool> DeleteAsync(int PK)
    {
        return await _repo.DeleteAsync(PK);
    }
}