using System.Text;
using Microsoft.Extensions.Logging;
namespace Library.Common;

internal class HttpHandler : IHttpHandler
{
    public const string ClientName = nameof(HttpHandler);

    private readonly HttpClient _client;

    public HttpHandler(IHttpClientFactory httpClientFactory, ILogger<HttpHandler> logger)
    {
        _client = httpClientFactory.CreateClient(ClientName);
    }

    public async Task<T> PostAsync<T>(string endpoint, object payload, CancellationToken cancellationToken)
    {
        var content = payload.ToJsonStringContent();
        var response = await _client.PostAsync(endpoint, content);
        return await HandleResponse<T>(response, cancellationToken);
    }

    public async Task<T> PutAsync<T>(string endpoint, object payload, CancellationToken cancellationToken)
    {
        var content = payload.ToJsonStringContent();
        var response = await _client.PutAsync(endpoint, content);
        return await HandleResponse<T>(response, cancellationToken);
    }

    public async Task<T> DeleteAsync<T>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await _client.DeleteAsync(endpoint);
        return await HandleResponse<T>(response, cancellationToken);
    }

    public async Task<T> GetAsync<T>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await _client.GetAsync(endpoint, cancellationToken);
        return await HandleResponse<T>(response, cancellationToken);
    }

    public async Task PostStream(string url, object data, Action<string> callback)
    {
        using var request = new HttpRequestMessage(HttpMethod.Post, url) { Content = data.ToJsonStringContent() };
        using var response = await _client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

        response.EnsureSuccessStatusCode();

        int bytesRead;
        var buffer = new byte[8192];
        using var responseStream = await response.Content.ReadAsStreamAsync();

        while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        {
            var chunk = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            callback(chunk);
        }
    }

    private static async Task<T> HandleResponse<T>(HttpResponseMessage response, CancellationToken cancellationToken)
    {
        response.EnsureSuccessStatusCode();
        return await response.DeserializeAs<T>(cancellationToken);
    }
}
