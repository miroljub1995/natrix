using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ExtendedAttributeRightHandSideInteger : ExtendedAttributeRightHandSide
{
    [JsonPropertyName("value")] public required string Value { get; set; }
}