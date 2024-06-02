using Library.Builders;
using Library.Models.Enum;
using Library.Models;
using Library.Api.v1.Request;
using Library.Models.Parameters;

namespace Library.Factories;

public static class GeminiRequestFactory
{
    public static GeminiRequest CreateDefaultRequest(
        string prompt,
        GenerationConfig? generationConfig,
        List<SafetySetting>? safetySettings)
    {
        return new GeminiRequest
        {
            Contents = new() 
            { 
                new ContentBuilder()
                                    .WithParts(prompt)
                                    .WithRole(Role.user)
                                    .Build() 
            },
            GenerationConfig = generationConfig,
            SafetySettings = safetySettings
        };
    }

    public static GeminiRequest CreateCustomRequest(
        List<Content> contents,
        GenerationConfig? generationConfig,
        List<SafetySetting>? safetySettings)
    {
        return new GeminiRequest
        {
            Contents = contents,
            GenerationConfig = generationConfig,
            SafetySettings = safetySettings
        };
    }
}