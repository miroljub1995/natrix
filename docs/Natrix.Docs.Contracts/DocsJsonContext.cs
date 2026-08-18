using System.Text.Json.Serialization;

namespace Natrix.Docs.Contracts;

/// <summary>
/// Source-generated metadata for everything that crosses the wire: the endpoint's responses, and
/// the SWR cache the server hands to the client with the page.
///
/// Both hosts put this in the resolver chain of their own <c>JsonSerializerOptions</c>. Generating
/// the metadata at build time is what makes that safe under the client's AOT compilation, where
/// the reflection-based serializer has no types to reflect over.
/// </summary>
/// <remarks>
/// Carries no <c>[JsonSourceGenerationOptions]</c> on purpose. A context used as a resolver for
/// someone else's options supplies the shape only — which types and properties exist, and how to
/// construct them. Naming policy, case sensitivity and the rest come from the options doing the
/// work, so declaring conventions here would only apply to <c>Default.Options</c>, which neither
/// host uses, and would read as though it settled something it does not.
/// </remarks>
[JsonSerializable(typeof(UserProfile))]
public sealed partial class DocsJsonContext : JsonSerializerContext;
