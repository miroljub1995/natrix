using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ExtendedAttributeRightHandSideIntegerList : ExtendedAttributeRightHandSide
{
    [JsonPropertyName("value")] public required List<ExtendedAttributeRightHandSideInteger> Value { get; set; }
}