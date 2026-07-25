using System.Text.Json.Serialization;

namespace Natrix.WebIDLGenerator.Models;

public class IDLParsed
{
    [JsonPropertyName("idlNames")] public required Dictionary<string, IDLRootType> IDLNames { get; set; }

    [JsonPropertyName("idlExtendedNames")]
    public Dictionary<string, List<IDLRootType>> IDLExtendedNames { get; set; } = new();
}