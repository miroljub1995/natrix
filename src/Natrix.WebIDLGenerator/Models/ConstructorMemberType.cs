using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record ConstructorMemberType : IDLInterfaceMemberType
{
    [JsonPropertyName("arguments")] public required List<Argument> Arguments { get; set; }
}