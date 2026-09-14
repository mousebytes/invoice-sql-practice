using Repo;
using Repo.Context;

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
        builder.Services.AddScoped<IDbContext>(sp => new RepoContext(connectionString));
        builder.Services.AddScoped<ITenantRepo, TenantRepo>();
        builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
        builder.Services.AddScoped<IInvoiceRepo, InvoiceRepo>();
        builder.Services.AddScoped<IInvoiceItemRepo, InvoiceItemRepo>();
    }
}