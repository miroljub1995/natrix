using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ValueDescriptionBoolean : ValueDescription
{
    [JsonPropertyName("value")] public required bool Value { get; set; }
}