using Library.Models;
using Library.Models.Parameters;

namespace Library.Api.v1.Request;

public sealed class GeminiRequest
{
    public required List<Content> Contents { get; set; } = [];
    public GenerationConfig? GenerationConfig { get; set; }
    public List<SafetySetting>? SafetySettings { get; set; } 
}
