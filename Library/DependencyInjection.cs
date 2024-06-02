using Library.Api.v1;
using Library.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Library;

public static class DependencyInjection
{
    public static void AddGeminiClient(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<GeminiOptions>(configuration.GetSection(nameof(GeminiOptions)));

        services.AddHttpClient(HttpHandler.ClientName, (provider, client) =>
        {
            var options = provider.GetRequiredService<IOptions<GeminiOptions>>().Value;
            client.DefaultRequestHeaders.Add("x-goog-api-key", options.ApiKey);
        });

        services.AddSingleton<IHttpHandler, HttpHandler>();
        services.AddSingleton<IGeminiClient, GeminiClient>();
    }
}
