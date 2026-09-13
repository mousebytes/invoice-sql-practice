using Microsoft.Extensions.DependencyInjection;

namespace ClientAPI;
public static class ClientAPISetup
{
    public static void RegisterDI(IServiceCollection services, string webapiAddress)
    {
        services.AddHttpClient<ITenantClientAPI, TenantClientAPI>(client => client.BaseAddress = new Uri(webapiAddress));
        services.AddHttpClient<ICustomerClientAPI, CustomerClientAPI>(client => client.BaseAddress = new Uri(webapiAddress));
        services.AddHttpClient<IInvoiceClientAPI, InvoiceClientAPI>(client => client.BaseAddress = new Uri(webapiAddress));
        services.AddHttpClient<IInvoiceItemClientAPI, InvoiceItemClientAPI>(client => client.BaseAddress = new Uri(webapiAddress));
    }
}