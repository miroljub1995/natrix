using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ExtendedAttributeRightHandSideStringList : ExtendedAttributeRightHandSide
{
    [JsonPropertyName("value")] public required List<ExtendedAttributeRightHandSideString> Value { get; set; }
}