using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record SequenceTypeDescription : NonUnionTypeDescription
{
    [JsonPropertyName("idlType")] public required List<IDLTypeDescription> IdlType { get; set; }
}