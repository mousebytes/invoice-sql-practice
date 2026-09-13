using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.ViewModels;

namespace WebAPI.Controllers;

public class InvoiceItemViewController : BaseController
{
    IInvoiceItemRepo _repo;

    public InvoiceItemViewController(IInvoiceItemRepo repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public async Task<InvoiceItemView> AddAsync([FromBody] InvoiceItem model)
    {
        return await _repo.AddAsync(model);
    }

    [HttpGet("{PK}")]
    public async Task<InvoiceItemView?> GetAsync(int PK)
    {
        return await _repo.GetAsync(PK);
    }

    [HttpGet]
    public async Task<IEnumerable<InvoiceItemView>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    [HttpPut]
    public async Task<InvoiceItemView> UpdateAsync([FromBody] InvoiceItem model)
    {
        return await _repo.UpdateAsync(model);
    }

    [HttpDelete("{PK}")]
    public async Task<bool> DeleteAsync(int PK)
    {
        return await _repo.DeleteAsync(PK);
    }
}