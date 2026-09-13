using System.Net.Http.Json;
using System.Text.Json;
using Models;

public class InvoiceClientAPI : BaseClientAPI, IInvoiceClientAPI
{
    public HttpClient _http;
    private readonly string _baseRequest = "Invoice";

    public InvoiceClientAPI(HttpClient http)
    {
        _http = http;
    }

    public async Task<Invoice> AddAsync(Invoice model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PostAsJsonAsync(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Invoice>();
    }

    public async Task<Invoice?> GetAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.GetFromJsonAsync<Invoice>(uri);
        return response;
    }

    public async Task<IEnumerable<Invoice>> GetAllAsync()
    {
        var uri = $"{_baseRequest}";
        var response = await _http.GetFromJsonAsync<IEnumerable<Invoice>>(uri);
        return response;
    }

    public async Task<Invoice> UpdateAsync(Invoice model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PutAsJsonAsync<Invoice>(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Invoice>();
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.DeleteAsync(uri);
        return response.IsSuccessStatusCode;
    }
}