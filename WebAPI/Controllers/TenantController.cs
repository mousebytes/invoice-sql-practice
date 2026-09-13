using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPI.Controllers;

public class TenantController : BaseController
{
    ITenantRepo _repo;

    public TenantController(ITenantRepo repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public async Task<Tenant> AddAsync([FromBody] Tenant model)
    {
        return await _repo.AddAsync(model);
    }

    [HttpGet("{PK}")]
    public async Task<Tenant?> GetAsync(int PK)
    {
        return await _repo.GetAsync(PK);
    }

    [HttpGet]
    public async Task<IEnumerable<Tenant>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    [HttpPut]
    public async Task<Tenant> UpdateAsync([FromBody] Tenant model)
    {
        return await _repo.UpdateAsync(model);
    }

    [HttpDelete("{PK}")]
    public async Task<bool> DeleteAsync(int PK)
    {
        return await _repo.DeleteAsync(PK);
    }
}