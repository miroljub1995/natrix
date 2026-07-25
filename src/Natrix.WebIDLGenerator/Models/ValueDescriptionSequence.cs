using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ValueDescriptionSequence : ValueDescription
{
    [JsonPropertyName("value")] public required List<object> Value { get; set; }
}