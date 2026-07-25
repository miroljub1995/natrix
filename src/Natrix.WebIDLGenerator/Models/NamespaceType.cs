using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record NamespaceType : AbstractContainer
{
    [JsonPropertyName("members")] public required List<IDLNamespaceMemberType> Members { get; set; }
}