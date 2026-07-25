using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record ConstantMemberType : IDLInterfaceMemberType
{
    [JsonPropertyName("idlType")] public required IDLTypeDescription IdlType { get; set; }

    [JsonPropertyName("name")] public required string Name { get; set; }

    [JsonPropertyName("value")] public required ValueDescription Value { get; set; }
}