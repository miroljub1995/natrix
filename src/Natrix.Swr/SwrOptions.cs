namespace Natrix.Swr;

/// <summary>
/// Configuration for a resource. Deliberately small: this port covers error retries and where a
/// resource fetches, and every other React SWR option (refresh intervals, revalidate-on-focus,
/// deduping windows, fallback data) is left out rather than half-implemented.
/// </summary>
/// <remarks>
/// Set app-wide through <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>, and adjusted per
/// resource by a callback that receives those defaults — <c>options => options with { … }</c> —
/// so a resource overrides what it cares about and inherits the rest. They belong to
/// the caller, not to the cache entry: two components sharing a key each retry on their own
/// terms, and whichever one starts a request drives its retries.
/// </remarks>
public sealed record SwrOptions
{
    /// <summary>
    /// Defaults matching React SWR's spirit: retry on error, with an interval short enough that
    /// a transient failure recovers without the user reloading.
    /// </summary>
    public static readonly SwrOptions Default = new();

    /// <summary>
    /// Whether a failed fetch is retried at all. When <c>false</c> a failure is final until
    /// something else triggers a revalidation.
    /// </summary>
    public bool ShouldRetryOnError { get; init; } = true;

    /// <summary>
    /// How many <em>additional</em> attempts follow the first failure. <c>0</c> disables retries
    /// as effectively as <see cref="ShouldRetryOnError"/> being <c>false</c>.
    /// </summary>
    /// <remarks>
    /// React SWR retries indefinitely by default; a bounded count is the safer default for a
    /// WebAssembly client, where an endless retry loop is invisible and unstoppable from
    /// outside the tab.
    /// </remarks>
    public int ErrorRetryCount { get; init; } = 3;

    /// <summary>
    /// Base delay before the first retry. Each subsequent attempt doubles it — attempt <c>n</c>
    /// waits <c>ErrorRetryInterval * 2^n</c>, capped at 2^8 — so a server that is down is not
    /// hammered at a fixed rate.
    /// </summary>
    /// <remarks>
    /// The backoff carries no random jitter, unlike React SWR's. Jitter spreads a herd of
    /// clients retrying in lockstep, which a single-tab client app is not, and its absence keeps
    /// retry timing predictable.
    /// </remarks>
    public TimeSpan ErrorRetryInterval { get; init; } = TimeSpan.FromSeconds(5);

    /// <summary>
    /// Whether the fetcher runs during server rendering. When <c>true</c>, binding a key on the
    /// server registers a prefetch the render waits for, and the value ships with the page. When
    /// <c>false</c> the resource is client-only: the server renders its loading state, nothing
    /// for the key is transferred, and the browser fetches after its first render as it would for
    /// any key the page did not carry.
    /// </summary>
    /// <remarks>
    /// <para>
    /// For data the server cannot or should not fetch — a request that needs a browser-only API
    /// or a credential only the browser holds, a value that is personal to the visitor and must
    /// not be rendered into cacheable markup, or one whose upstream is too slow to hold the
    /// response for.
    /// </para>
    /// <para>
    /// Hydration stays consistent either way: the server's markup shows the loading state and the
    /// client's first render, seeing no value for the key, shows the same. The setting is the
    /// caller's, not the entry's — a client-only resource sharing a key with one that does fetch
    /// on the server receives the prefetched value like any other subscriber.
    /// </para>
    /// </remarks>
    public bool FetchOnServer { get; init; } = true;

    /// <summary>
    /// Validated where options enter the library rather than in an <c>init</c> accessor, so the
    /// exception points at the <c>Swr.Use</c> / <c>UseSwr</c> call that supplied them.
    /// </summary>
    internal void Validate()
    {
        ArgumentOutOfRangeException.ThrowIfNegative(ErrorRetryCount, nameof(ErrorRetryCount));
        ArgumentOutOfRangeException.ThrowIfLessThan(ErrorRetryInterval, TimeSpan.Zero, nameof(ErrorRetryInterval));
    }

    /// <summary>
    /// Delay before the retry that follows failure number <paramref name="attempt"/>
    /// (zero-based).
    /// </summary>
    internal TimeSpan GetRetryDelay(int attempt)
    {
        var multiplier = 1L << Math.Min(attempt, 8);
        return TimeSpan.FromTicks(ErrorRetryInterval.Ticks * multiplier);
    }
}
