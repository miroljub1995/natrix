using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class EnumValue
{
    [JsonPropertyName("value")] public required string Value { get; set; }
}