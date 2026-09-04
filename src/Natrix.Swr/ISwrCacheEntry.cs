using System.Text.Json.Nodes;

namespace Natrix.Swr;

/// <summary>
/// The type-erased face of a cache entry, so <see cref="SwrCache"/> can hold entries of mixed
/// data types and still stop their pending work and serialize them without knowing their shape.
/// </summary>
internal interface ISwrCacheEntry
{
    void CancelPending();

    /// <summary>
    /// Produces the entry's value for the hydration payload.
    /// </summary>
    /// <returns>
    /// <c>false</c> when there is nothing to transfer — no value has been fetched, or the entry
    /// has no <c>JsonTypeInfo</c> because the application did not configure serialization.
    /// Distinct from succeeding with a <c>null</c> node, which is what a fetched <c>null</c>
    /// serializes to and must still be transferred.
    /// </returns>
    bool TryDehydrate(out JsonNode? node);
}
