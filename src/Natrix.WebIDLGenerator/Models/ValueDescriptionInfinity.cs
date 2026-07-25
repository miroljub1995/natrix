using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class ValueDescriptionInfinity : ValueDescription
{
    [JsonPropertyName("negative")] public required bool Negative { get; set; }
}