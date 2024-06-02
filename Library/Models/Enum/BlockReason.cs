using System.Runtime.Serialization;

namespace Library.Models.Enum;

public enum BlockReason
{
    [EnumMember(Value = "SAFETY")]
    Safety = 0,

    [EnumMember(Value = "OTHER")]
    Other = 1
}
