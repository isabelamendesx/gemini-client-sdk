namespace Library.Models;

public sealed class Part
{
    public string Text { get; set; } = string.Empty;

    public static implicit operator string(Part part) => part?.Text ?? string.Empty;
}
