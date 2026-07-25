using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record EnumType : IDLRootType
{
    [JsonPropertyName("name")] public required string Name { get; set; }

    [JsonPropertyName("values")] public required List<EnumValue> Values { get; set; }
}