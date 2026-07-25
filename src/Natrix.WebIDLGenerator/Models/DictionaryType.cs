using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record DictionaryType : AbstractContainer
{
    [JsonPropertyName("members")] public required List<FieldType> Members { get; set; }

    [JsonPropertyName("inheritance")] public string? Inheritance { get; set; }
}