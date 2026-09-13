using System.Net.Http.Json;
using System.Text.Json;
using Models;

public class CustomerClientAPI : BaseClientAPI, ICustomerClientAPI
{
    public HttpClient _http;
    private readonly string _baseRequest = "Customer";

    public CustomerClientAPI(HttpClient http)
    {
        _http = http;
    }

    public async Task<Customer> AddAsync(Customer model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PostAsJsonAsync(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Customer>();
    }

    public async Task<Customer?> GetAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.GetFromJsonAsync<Customer>(uri);
        return response;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        var uri = $"{_baseRequest}";
        var response = await _http.GetFromJsonAsync<IEnumerable<Customer>>(uri);
        return response;
    }

    public async Task<Customer> UpdateAsync(Customer model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PutAsJsonAsync<Customer>(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Customer>();
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.DeleteAsync(uri);
        return response.IsSuccessStatusCode;
    }
}