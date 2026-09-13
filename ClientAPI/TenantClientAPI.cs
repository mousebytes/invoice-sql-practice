using System.Net.Http.Json;
using System.Text.Json;
using Models;

public class TenantClientAPI : BaseClientAPI, ITenantClientAPI
{
    public HttpClient _http;
    private readonly string _baseRequest = "Tenant";

    public TenantClientAPI(HttpClient http)
    {
        _http = http;
    }

    public async Task<Tenant> AddAsync(Tenant model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PostAsJsonAsync(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Tenant>();
    }

    public async Task<Tenant?> GetAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.GetFromJsonAsync<Tenant>(uri);
        return response;
    }

    public async Task<IEnumerable<Tenant>> GetAllAsync()
    {
        var uri = $"{_baseRequest}";
        var response = await _http.GetFromJsonAsync<IEnumerable<Tenant>>(uri);
        return response;
    }

    public async Task<Tenant> UpdateAsync(Tenant model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PutAsJsonAsync<Tenant>(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Tenant>();
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.DeleteAsync(uri);
        return response.IsSuccessStatusCode;
    }
}