using Library.Api.v1.Response;
using Library.Models;
using Library.Models.Parameters;

namespace Library.Api.v1
{
    public interface IGeminiClient
    {
        Task<GeminiResponse> SendTextPrompt(List<Content> contents, GenerationConfig? generationConfig = null, List<SafetySetting>? safetySettings = null, CancellationToken cancellationToken = default);
        Task<GeminiResponse> SendTextPrompt(string prompt, GenerationConfig? generationConfig = null, List<SafetySetting>? safetySettings = null, CancellationToken cancellationToken = default);
    }
}