namespace Natrix.Query;

/// <summary>
/// The tri-state TypeScript-style <c>true | false | 'always'</c> used by the
/// <c>refetchOnMount</c> / <c>refetchOnWindowFocus</c> / <c>refetchOnReconnect</c> options.
/// </summary>
public enum RefetchOnValue
{
    /// <summary>Never refetch on this trigger.</summary>
    False,

    /// <summary>Refetch on this trigger, but only when the data is stale.</summary>
    True,

    /// <summary>Refetch on this trigger even when the data is still fresh.</summary>
    Always,
}

/// <summary>
/// <c>refetchOnMount</c> / <c>refetchOnWindowFocus</c> / <c>refetchOnReconnect</c>:
/// a <see cref="bool"/>, <see cref="RefetchOnValue.Always"/>, or a function of the query.
/// </summary>
/// <example>
/// <code>
/// RefetchOnWindowFocus = false,
/// RefetchOnMount = RefetchOnValue.Always,
/// RefetchOnReconnect = (Query q) =&gt; q.State.Status == QueryStatus.Error
///     ? RefetchOnValue.Always
///     : RefetchOnValue.True,
/// </code>
/// </example>
public readonly struct RefetchOnOption
{
    private readonly RefetchOnValue _value;
    private readonly Func<Query, RefetchOnValue>? _resolver;

    private RefetchOnOption(RefetchOnValue value, Func<Query, RefetchOnValue>? resolver)
    {
        _value = value;
        _resolver = resolver;
    }

    public static implicit operator RefetchOnOption(bool value) =>
        new(value ? RefetchOnValue.True : RefetchOnValue.False, null);

    public static implicit operator RefetchOnOption(RefetchOnValue value) => new(value, null);

    public static implicit operator RefetchOnOption(Func<Query, RefetchOnValue> resolver) =>
        new(RefetchOnValue.False, resolver ?? throw new ArgumentNullException(nameof(resolver)));

    /// <summary>Named alternative to the <see cref="bool"/> conversion.</summary>
    public static RefetchOnOption FromBool(bool value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static RefetchOnOption FromFunc(Func<Query, RefetchOnValue> resolver) => resolver;

    public RefetchOnValue Resolve(Query query) => _resolver is null ? _value : _resolver(query);
}

/// <summary>
/// <c>enabled</c>: a <see cref="bool"/> or a function of the query. A disabled query never
/// fetches on its own, is excluded from <see cref="QueryTypeFilter.Active"/> filters, and
/// stays <see cref="QueryStatus.Pending"/> until something gives it data.
/// </summary>
public readonly struct EnabledOption
{
    private readonly bool _hasValue;
    private readonly bool _value;
    private readonly Func<Query, bool>? _resolver;

    private EnabledOption(bool hasValue, bool value, Func<Query, bool>? resolver)
    {
        _hasValue = hasValue;
        _value = value;
        _resolver = resolver;
    }

    public static implicit operator EnabledOption(bool value) => new(true, value, null);

    public static implicit operator EnabledOption(Func<Query, bool> resolver) =>
        new(true, true, resolver ?? throw new ArgumentNullException(nameof(resolver)));

    /// <summary>Named alternative to the <see cref="bool"/> conversion.</summary>
    public static EnabledOption FromBool(bool value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static EnabledOption FromFunc(Func<Query, bool> resolver) => resolver;

    public bool Resolve(Query query) => !_hasValue || (_resolver is null ? _value : _resolver(query));
}

/// <summary>
/// <c>retry</c>: <c>false</c> (never), <c>true</c> (forever), a maximum attempt count, or a
/// predicate over the failure count and the error.
/// </summary>
/// <example>
/// <code>
/// Retry = false,
/// Retry = 3,
/// Retry = (int failureCount, Exception error) =&gt; failureCount &lt; 3 &amp;&amp; error is not HttpRequestException,
/// </code>
/// </example>
public readonly struct RetryOption
{
    private readonly bool _hasValue;
    private readonly bool _infinite;
    private readonly int _count;
    private readonly Func<int, Exception, bool>? _predicate;

    private RetryOption(bool hasValue, bool infinite, int count, Func<int, Exception, bool>? predicate)
    {
        _hasValue = hasValue;
        _infinite = infinite;
        _count = count;
        _predicate = predicate;
    }

    public static implicit operator RetryOption(bool value) => new(true, value, 0, null);

    public static implicit operator RetryOption(int count) => new(true, false, count, null);

    public static implicit operator RetryOption(Func<int, Exception, bool> predicate) =>
        new(true, false, 0, predicate ?? throw new ArgumentNullException(nameof(predicate)));

    /// <summary>Named alternative to the <see cref="bool"/> conversion.</summary>
    public static RetryOption FromBool(bool value) => value;

    /// <summary>Named alternative to the <see cref="int"/> conversion.</summary>
    public static RetryOption FromCount(int count) => count;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static RetryOption FromFunc(Func<int, Exception, bool> predicate) => predicate;

    /// <summary>
    /// Whether an attempt that has already failed <paramref name="failureCount"/> times with
    /// <paramref name="error"/> should be tried again.
    /// </summary>
    public bool ShouldRetry(int failureCount, Exception error)
    {
        if (!_hasValue)
        {
            return false;
        }

        if (_predicate is not null)
        {
            return _predicate(failureCount, error);
        }

        return _infinite || failureCount < _count;
    }
}

/// <summary>
/// <c>staleTime</c>: how long fetched data stays fresh, as a <see cref="TimeSpan"/> or a
/// function of the query. Use <see cref="QueryTime.Infinity"/> for data that never goes stale
/// by itself.
/// </summary>
public readonly struct StaleTimeOption
{
    private readonly TimeSpan _value;
    private readonly Func<Query, TimeSpan>? _resolver;

    private StaleTimeOption(TimeSpan value, Func<Query, TimeSpan>? resolver)
    {
        _value = value;
        _resolver = resolver;
    }

    public static implicit operator StaleTimeOption(TimeSpan value) => new(value, null);

    public static implicit operator StaleTimeOption(Func<Query, TimeSpan> resolver) =>
        new(TimeSpan.Zero, resolver ?? throw new ArgumentNullException(nameof(resolver)));

    /// <summary>Named alternative to the <see cref="TimeSpan"/> conversion.</summary>
    public static StaleTimeOption FromTimeSpan(TimeSpan value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static StaleTimeOption FromFunc(Func<Query, TimeSpan> resolver) => resolver;

    public TimeSpan Resolve(Query query) => _resolver is null ? _value : _resolver(query);
}

/// <summary>
/// <c>refetchInterval</c>: poll every <see cref="TimeSpan"/>, or decide per query. A
/// <c>null</c> interval — the default — disables polling.
/// </summary>
public readonly struct RefetchIntervalOption
{
    private readonly TimeSpan? _value;
    private readonly Func<Query, TimeSpan?>? _resolver;

    private RefetchIntervalOption(TimeSpan? value, Func<Query, TimeSpan?>? resolver)
    {
        _value = value;
        _resolver = resolver;
    }

    public static implicit operator RefetchIntervalOption(TimeSpan value) => new(value, null);

    public static implicit operator RefetchIntervalOption(TimeSpan? value) => new(value, null);

    public static implicit operator RefetchIntervalOption(Func<Query, TimeSpan?> resolver) =>
        new(null, resolver ?? throw new ArgumentNullException(nameof(resolver)));

    /// <summary>Named alternative to the <see cref="TimeSpan"/> conversion.</summary>
    public static RefetchIntervalOption FromTimeSpan(TimeSpan? value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static RefetchIntervalOption FromFunc(Func<Query, TimeSpan?> resolver) => resolver;

    public TimeSpan? Resolve(Query query) => _resolver is null ? _value : _resolver(query);
}

/// <summary>
/// <c>initialData</c>: data seeded into the cache before the first fetch, given directly or
/// produced lazily. Unlike <c>placeholderData</c> it is persisted in the cache and is
/// indistinguishable from fetched data.
/// </summary>
public readonly struct InitialDataOption<TData>
{
    private readonly bool _hasValue;
    private readonly TData? _value;
    private readonly Func<TData?>? _factory;

    private InitialDataOption(bool hasValue, TData? value, Func<TData?>? factory)
    {
        _hasValue = hasValue;
        _value = value;
        _factory = factory;
    }

    /// <summary>Whether initial data was configured at all.</summary>
    public bool HasValue => _hasValue;

    public static implicit operator InitialDataOption<TData>(TData value) => new(true, value, null);

    public static implicit operator InitialDataOption<TData>(Func<TData?> factory) =>
        new(true, default, factory ?? throw new ArgumentNullException(nameof(factory)));

    /// <summary>Named alternative to the value conversion.</summary>
    public static InitialDataOption<TData> FromValue(TData value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static InitialDataOption<TData> FromFunc(Func<TData?> factory) => factory;

    /// <summary>Produces the initial data, calling the factory if one was supplied.</summary>
    public TData? Resolve() => _factory is null ? _value : _factory();
}

/// <summary>
/// <c>placeholderData</c>: data shown while the real data is loading. It is never written to
/// the cache, and a result carrying it is flagged through <c>IsPlaceholderData</c>.
/// </summary>
/// <remarks>
/// The function form receives the data and the query of the last key that had data, which is
/// what makes <see cref="KeepPreviousData"/> smooth over key changes.
/// </remarks>
public readonly struct PlaceholderDataOption<TQueryFnData>
{
    private readonly bool _hasValue;
    private readonly TQueryFnData? _value;
    private readonly Func<TQueryFnData?, Query?, TQueryFnData?>? _factory;

    private PlaceholderDataOption(
        bool hasValue,
        TQueryFnData? value,
        Func<TQueryFnData?, Query?, TQueryFnData?>? factory)
    {
        _hasValue = hasValue;
        _value = value;
        _factory = factory;
    }

    /// <summary>Whether placeholder data was configured at all.</summary>
    public bool HasValue => _hasValue;

    /// <summary>
    /// The equivalent of TanStack Query's <c>keepPreviousData</c>: keep showing the previous
    /// key's data while the new key loads.
    /// </summary>
    public static PlaceholderDataOption<TQueryFnData> KeepPreviousData { get; } =
        new(true, default, static (previous, _) => previous);

    public static implicit operator PlaceholderDataOption<TQueryFnData>(TQueryFnData value) =>
        new(true, value, null);

    public static implicit operator PlaceholderDataOption<TQueryFnData>(
        Func<TQueryFnData?, Query?, TQueryFnData?> factory) =>
        new(true, default, factory ?? throw new ArgumentNullException(nameof(factory)));

    /// <summary>Named alternative to the value conversion.</summary>
    public static PlaceholderDataOption<TQueryFnData> FromValue(TQueryFnData value) => value;

    /// <summary>Named alternative to the delegate conversion.</summary>
    public static PlaceholderDataOption<TQueryFnData> FromFunc(
        Func<TQueryFnData?, Query?, TQueryFnData?> factory) => factory;

    /// <summary>
    /// Produces the placeholder, given the data and query of the last key that had data.
    /// </summary>
    public TQueryFnData? Resolve(TQueryFnData? previousData, Query? previousQuery) =>
        _factory is null ? _value : _factory(previousData, previousQuery);
}

/// <summary>Well-known durations for the time-based query options.</summary>
public static class QueryTime
{
    /// <summary>
    /// "Never on its own" — the counterpart of TanStack Query's <c>Infinity</c> for
    /// <c>staleTime</c> and <c>gcTime</c>.
    /// </summary>
    public static TimeSpan Infinity => TimeSpan.MaxValue;
}
