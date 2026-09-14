using Models;

namespace Blazor.Pages;
public partial class Customers
{
    IEnumerable<Customer> _customers;
    protected override async Task OnInitializedAsync()
    {
        await LoadCustomers();
    }

    private async Task LoadCustomers()
    {
        var retrieved = await _apiClient.GetAllAsync() ?? [];
        _customers = retrieved;        
    }
}