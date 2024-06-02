using System.Runtime.Serialization;

namespace Library.Models.Enum;

public enum Probability
{
    [EnumMember(Value = "HARM_PROBABILITY_UNSPECIFIED")]
    Unspecified = 0,

    [EnumMember(Value = "NEGLIGIBLE")]
    Negligible = 1,

    [EnumMember(Value = "MEDIUM")]
    Medium = 2,

    [EnumMember(Value = "HIGH")]
    High = 3
}
