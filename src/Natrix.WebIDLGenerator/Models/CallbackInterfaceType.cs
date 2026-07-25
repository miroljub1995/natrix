using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record CallbackInterfaceType : AbstractContainer
{
    [JsonPropertyName("members")] public required List<IDLCallbackInterfaceMemberType> Members { get; set; }
}