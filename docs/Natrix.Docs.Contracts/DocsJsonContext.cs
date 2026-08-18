using System.Text.Json.Serialization;

namespace Natrix.Docs.Contracts;

/// <summary>
/// Source-generated metadata for everything that crosses the wire: the endpoint's responses, and
/// the SWR cache the server hands to the client with the page.
///
/// Both hosts pass <c>Default.Options</c> to <c>UseSwr</c>. Generating the metadata at build time
/// is what makes the transfer safe under the client's AOT compilation, where the reflection-based
/// serializer has no types to reflect over.
/// </summary>
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(UserProfile))]
public sealed partial class DocsJsonContext : JsonSerializerContext;
