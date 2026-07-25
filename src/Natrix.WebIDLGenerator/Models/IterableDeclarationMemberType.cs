using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public record IterableDeclarationMemberType : DeclarationMemberType
{
    [JsonPropertyName("async")] public required bool Async { get; set; }

    [JsonPropertyName("arguments")] public required List<Argument> Arguments { get; set; }
}