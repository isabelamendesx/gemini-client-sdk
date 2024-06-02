
namespace Library.Models;

public sealed class UsageMetadata
{
    public int promptTokenCount {  get; set; }
    public int candidatesTokenCount {  get; set; }
    public int totalTokenCount {  get; set; }
}
