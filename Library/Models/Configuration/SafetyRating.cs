using Library.Models.Enum;

namespace Library.Models.Configuration;

public sealed class SafetyRating
{
    public Category Category { get; set; }
    public Probability Probability { get; set; }
}
