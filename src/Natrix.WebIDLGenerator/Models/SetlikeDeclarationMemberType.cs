using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record SetlikeDeclarationMemberType : DeclarationMemberType
{
    [JsonPropertyName("readonly")] public required bool Readonly { get; set; }
}