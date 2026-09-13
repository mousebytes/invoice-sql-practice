using Repo;

namespace WebAPI;
public static class RepoSetup
{
    public static void RegisterDI(WebApplicationBuilder builder)
    {
        InjectRepos(builder);
    }

    private static void InjectRepos(WebApplicationBuilder builder)
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";
        builder.Services.AddScoped<TenantRepo>(sp => new TenantRepo(connectionString));
        builder.Services.AddScoped<CustomerRepo>(sp => new CustomerRepo(connectionString));
        builder.Services.AddScoped<InvoiceRepo>(sp => new InvoiceRepo(connectionString));
        builder.Services.AddScoped<InvoiceItemRepo>(sp => new InvoiceItemRepo(connectionString));
    }
}