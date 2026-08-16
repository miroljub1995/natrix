namespace Natrix.Query;

/// <summary>
/// What a query function is handed when it runs — the C# counterpart of TanStack Query's
/// <c>QueryFunctionContext</c>.
/// </summary>
/// <remarks>
/// <see cref="Signal"/> is the <c>AbortSignal</c> equivalent: pass it to <c>HttpClient</c> (or
/// whatever performs the request) and cancelling a query — a key change, an explicit
/// <c>CancelQueries</c>, a refetch that supersedes this one — aborts the in-flight request
/// instead of leaving it running.
/// <para>
/// Reading <see cref="Signal"/> also tells the query that its function honours cancellation,
/// which is what lets an abandoned query be cancelled outright rather than merely left to
/// finish. This mirrors how TanStack Query watches for access to <c>signal</c>.
/// </para>
/// </remarks>
public class QueryFunctionContext
{
    private readonly CancellationToken _signal;
    private readonly Action _onSignalConsumed;

    internal protected QueryFunctionContext(
        QueryClient client,
        QueryKey queryKey,
        CancellationToken signal,
        IReadOnlyDictionary<string, object?>? meta,
        Action onSignalConsumed)
    {
        Client = client;
        QueryKey = queryKey;
        Meta = meta;
        _signal = signal;
        _onSignalConsumed = onSignalConsumed;
    }

    /// <summary>The client that owns the query, so a query function can read or seed other entries.</summary>
    public QueryClient Client { get; }

    /// <summary>The key the query was registered under.</summary>
    public QueryKey QueryKey { get; }

    /// <summary>Cancellation for this attempt.</summary>
    public CancellationToken Signal
    {
        get
        {
            _onSignalConsumed();
            return _signal;
        }
    }

    /// <summary>Arbitrary metadata attached through the <c>Meta</c> option.</summary>
    public IReadOnlyDictionary<string, object?>? Meta { get; }

    /// <summary>
    /// The token without the side effect of marking the query function as cancellation-aware.
    /// For derived contexts that pass it on rather than consuming it themselves.
    /// </summary>
    internal CancellationToken RawSignal => _signal;

    /// <summary>The callback that records access to <see cref="Signal"/>.</summary>
    internal Action SignalConsumedCallback => _onSignalConsumed;
}
