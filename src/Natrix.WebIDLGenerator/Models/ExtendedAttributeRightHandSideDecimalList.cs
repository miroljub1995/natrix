using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ExtendedAttributeRightHandSideDecimalList : ExtendedAttributeRightHandSide
{
    [JsonPropertyName("value")] public required List<ExtendedAttributeRightHandSideDecimal> Value { get; set; }
}