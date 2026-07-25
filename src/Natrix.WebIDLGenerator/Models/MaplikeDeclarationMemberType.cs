using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record MaplikeDeclarationMemberType : DeclarationMemberType
{
    [JsonPropertyName("readonly")] public required bool Readonly { get; set; }
}