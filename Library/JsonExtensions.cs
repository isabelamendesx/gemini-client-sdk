using Newtonsoft.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Library;

public static class JsonExtensions
{
    public static StringContent ToJsonStringContent(this object obj, JsonSerializerOptions? options = null) 
        => new StringContent(obj.Serialize(options ?? jsonOptions), Encoding.UTF8, "application/json");

    public static string Serialize(this object obj, JsonSerializerOptions? options = null)
        => JsonSerializer.Serialize(obj, options ?? jsonOptions);

    public static async Task<T> DeserializeAs<T>(
        this HttpResponseMessage response,
        CancellationToken cancellationToken = default)
    {
        var content = await response.Content.ReadAsStringAsync(cancellationToken);

        return JsonConvert.DeserializeObject<T>(content)
            ?? throw new JsonReaderException("Cannot deserialize JSON");
    }

    private static JsonSerializerOptions jsonOptions
    = new JsonSerializerOptions
    {
        Converters = { new JsonStringEnumConverter() },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };
}
