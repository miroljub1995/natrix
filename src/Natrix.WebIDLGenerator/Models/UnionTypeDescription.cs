using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record UnionTypeDescription : IDLTypeDescription
{
    [JsonPropertyName("idlType")] public required List<IDLTypeDescription> IdlType { get; set; }
}