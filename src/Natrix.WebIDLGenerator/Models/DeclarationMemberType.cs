using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public abstract record DeclarationMemberType : IDLInterfaceMemberType
{
    [JsonPropertyName("idlType")] public required List<IDLTypeDescription> IdlType { get; set; }
}