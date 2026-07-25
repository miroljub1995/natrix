using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record SingleTypeDescription : NonUnionTypeDescription
{
    [JsonPropertyName("idlType")] public required string IdlType { get; set; }
}