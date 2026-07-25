using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class IDLModule
{
    [JsonPropertyName("idlparsed")] public required IDLParsed IDLParsed { get; set; }
}