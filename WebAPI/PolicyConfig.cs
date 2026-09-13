public static class PolicyConfig
{
    public static void Begin(IServiceCollection services)
    {
        RegisterBlazor(services);
    }

    private static void RegisterBlazor(IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowBlazorClient", policy =>
            {
                policy.WithOrigins("http://localhost:5117")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }
}