using Library.Models.Configuration;
using Library.Models.Enum;

namespace Library.Models;

public sealed class Candidate
{
    public Content Content { get; set; } = null!;
    public FinishReason FinishReason { get; set; }
    public int Index { get; set; }
    public List<SafetyRating> SafetyRatings { get; set; } = new List<SafetyRating>();
}
