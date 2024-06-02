
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Library.Models.Enum;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Category
{
    [EnumMember(Value = "HARM_CATEGORY_UNSPECIFIED")]
    Unspecified = 0,

    [EnumMember(Value = "HARM_CATEGORY_DEROGATORY")]
    Derogatory = 1,

    [EnumMember(Value = "HARM_CATEGORY_TOXICITY")]
    Toxicity = 2,

    [EnumMember(Value = "HARM_CATEGORY_VIOLENCE")]
    Violence = 3,

    [EnumMember(Value = "HARM_CATEGORY_SEXUAL")]
    Sexual = 4,

    [EnumMember(Value = "HARM_CATEGORY_MEDICAL")]
    Medical = 5,

    [EnumMember(Value = "HARM_CATEGORY_DANGEROUS")]
    Dangerous = 6,

    [EnumMember(Value = "HARM_CATEGORY_HARASSMENT")]
    Harassment = 7,

    [EnumMember(Value = "HARM_CATEGORY_HATE_SPEECH")]
    HateSpeech = 8,

    [EnumMember(Value = "HARM_CATEGORY_SEXUALLY_EXPLICIT")]
    SexuallyExplicit = 9,

    [EnumMember(Value = "HARM_CATEGORY_DANGEROUS_CONTENT")]
    DangerousContent = 10
}