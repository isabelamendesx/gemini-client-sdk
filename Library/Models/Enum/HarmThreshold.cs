using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Library.Models.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HarmThreshold
{
    [EnumMember(Value = "HARM_BLOCK_THRESHOLD_UNSPECIFIED")]
    Unspecified = 0,

    [EnumMember(Value = "BLOCK_LOW_AND_ABOVE")]
    LowAndAbove = 1,

    [EnumMember(Value = "BLOCK_MEDIUM_AND_ABOVE")]
    MediumAndAbove = 2,

    [EnumMember(Value = "BLOCK_ONLY_HIGH")]
    OnlyHigh = 3,

    [EnumMember(Value = "BLOCK_NONE")]
    None = 4
}