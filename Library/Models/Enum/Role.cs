
using System.Text.Json.Serialization;

namespace Library.Models.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Role
{
    user = 0, 
    model = 1
}
