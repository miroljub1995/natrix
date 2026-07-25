using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record InterfaceMixinType : AbstractContainer
{
    [JsonPropertyName("members")] public required List<IDLInterfaceMixinMemberType> Members { get; set; }
}