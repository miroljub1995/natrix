using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ExtendedAttributeRightHandSideDecimal : ExtendedAttributeRightHandSide
{
    [JsonPropertyName("value")] public required string Value { get; set; }
}