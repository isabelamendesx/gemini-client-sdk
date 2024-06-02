using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Library.Models.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FinishReason
{
    [EnumMember(Value = "FINISH_REASON_UNSPECIFIED")]
    Unspecified = 0,

    [EnumMember(Value = "STOP")]
    Stop = 1,

    [EnumMember(Value = "MAX_TOKENS")]
    MaxTokens = 2,

    [EnumMember(Value = "SAFETY")]
    Safety = 3,

    [EnumMember(Value = "RECITATION")]
    Recitation = 4,

    [EnumMember(Value = "OTHER")]
    Other = 5
}
