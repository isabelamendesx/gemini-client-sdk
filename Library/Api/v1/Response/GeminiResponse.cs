using Library.Models;

namespace Library.Api.v1.Response;

public sealed class GeminiResponse
{
    public List<Candidate>? Candidates { get; set; } = [];
    public PrompFeedback? PrompFeedback { get; set; } = null!;

    public UsageMetadata? UsageMetadata { get; set; }
}

