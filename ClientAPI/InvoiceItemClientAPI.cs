using System.Net.Http.Json;
using System.Text.Json;
using Models;
using Models.ViewModels;

public class InvoiceItemClientAPI : BaseClientAPI, IInvoiceItemClientAPI
{
    public HttpClient _http;
    private readonly string _baseRequest = "InvoiceItemView";

    public InvoiceItemClientAPI(HttpClient http)
    {
        _http = http;
    }

    public async Task<InvoiceItemView> AddAsync(InvoiceItem model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PostAsJsonAsync(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<InvoiceItemView>();
    }

    public async Task<InvoiceItemView?> GetAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.GetFromJsonAsync<InvoiceItemView>(uri);
        return response;
    }

    public async Task<IEnumerable<InvoiceItemView>> GetAllAsync()
    {
        var uri = $"{_baseRequest}";
        var response = await _http.GetFromJsonAsync<IEnumerable<InvoiceItemView>>(uri);
        return response;
    }

    public async Task<InvoiceItemView> UpdateAsync(InvoiceItem model)
    {
        var uri = $"{_baseRequest}";
        var response = await _http.PutAsJsonAsync<InvoiceItem>(uri, model);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<InvoiceItemView>();
    }

    public async Task<bool> DeleteAsync(int PK)
    {
        var uri = $"{_baseRequest}/{PK}";
        var response = await _http.DeleteAsync(uri);
        return response.IsSuccessStatusCode;
    }
}