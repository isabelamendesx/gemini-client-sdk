namespace Library;

public class GeminiOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string TextBaseUrl { get; set; } =
    "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent";
}
