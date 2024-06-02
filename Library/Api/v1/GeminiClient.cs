using Library.Api.v1.Response;
using Library.Common;
using Library.Factories;
using Library.Models.Parameters;
using Library.Models;
using Microsoft.Extensions.Options;

namespace Library.Api.v1;

public sealed class GeminiClient : IGeminiClient
{
    private readonly IHttpHandler _httpHandler;
    private readonly GeminiOptions _options;

    public GeminiClient(IHttpHandler httpHandler, IOptions<GeminiOptions> options)
    {
        _httpHandler = httpHandler;
        _options = options.Value;
    }

    public async Task<GeminiResponse> SendTextPrompt(
        string prompt,
        GenerationConfig? generationConfig = null,
        List<SafetySetting>? safetySettings = null,
        CancellationToken cancellationToken = default)
    {
        var payload = GeminiRequestFactory.CreateDefaultRequest(prompt, generationConfig, safetySettings);
        return await _httpHandler.PostAsync<GeminiResponse>(_options.TextBaseUrl, payload, cancellationToken);
    }

    public async Task<GeminiResponse> SendTextPrompt(
        List<Content> contents,
        GenerationConfig? generationConfig = null,
        List<SafetySetting>? safetySettings = null,
        CancellationToken cancellationToken = default)
    {
        var endpoint = $":generateContent?key=";
        var payload = GeminiRequestFactory.CreateCustomRequest(contents, generationConfig, safetySettings);
        return await _httpHandler.PostAsync<GeminiResponse>(_options.TextBaseUrl, payload, cancellationToken);
    }

}
