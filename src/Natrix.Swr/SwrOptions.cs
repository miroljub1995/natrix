namespace Natrix.Swr;

/// <summary>
/// Configuration for a resource. Deliberately small: this port covers error retries only, and
/// every other React SWR option (refresh intervals, revalidate-on-focus, deduping windows,
/// fallback data) is left out rather than half-implemented.
/// </summary>
/// <remarks>
/// Options are supplied per <see cref="SwrResource.Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, SwrOptions?)"/>
/// call, or app-wide through <see cref="NatrixHostBuilderSwrExtensions.UseSwr"/>. They belong to
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
