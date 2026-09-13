using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using InvoiceApp;
using ClientAPI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

string apiBaseUrl = builder.Configuration["ApiBaseUri"] ?? throw new InvalidOperationException("ApiBaseUrl is missing from appsettings");

ClientAPISetup.RegisterDI(builder.Services, apiBaseUrl);

var host = builder.Build();

await host.RunAsync();