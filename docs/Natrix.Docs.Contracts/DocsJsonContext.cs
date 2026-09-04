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
/// <para>
/// Carries no <c>[JsonSourceGenerationOptions]</c>, because nothing here would need one. Those
/// settings split in two: whatever the generator can bake into the metadata — the converters it
/// emits, such as <c>UseStringEnumConverter</c> — travels with the context into any options that
/// resolve through it, while settings that are properties of a <c>JsonSerializerOptions</c>
/// instance — naming policy, case sensitivity — do not, and come from the options doing the work.
/// </para>
/// <para>
/// So a naming policy declared here would apply only to <c>Default.Options</c>, which neither host
/// uses: both put this context in the chain of options they own, and those options decide the
/// casing. It would read as though it settled the wire format while settling nothing. Add the
/// attribute if a type ever needs a converter the generator has to emit.
/// </para>
/// </remarks>
[JsonSerializable(typeof(UserProfile))]
public sealed partial class DocsJsonContext : JsonSerializerContext;
