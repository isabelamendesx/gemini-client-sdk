using Library.Models.Configuration;
using Library.Models.Enum;

namespace Library.Models;

public sealed class PrompFeedback
{
    public BlockReason BlockReason { get; set; }
    public List<SafetyRating> SafetyRattings { get; set; } = [];
 }
