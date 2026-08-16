using Natrix.Core.Features;
using Natrix.Query.Features;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.Features;

namespace Natrix.Query;

/// <summary>
/// The composables — the Natrix counterpart of Vue Query's <c>useQuery</c> family. Import them
/// unqualified with <c>using static Natrix.Query.NatrixQuery;</c> and call them from a
/// component's <c>Setup</c>.
/// </summary>
/// <remarks>
/// <para>
/// Every composable ties itself to the component's reactive scope: the observer is created
/// during setup, disposed when the component unmounts, and reconfigured whenever a signal its
/// options read changes. That is why the options are usually passed as a factory — the factory
/// is the reactive expression.
/// </para>
/// <para>
/// During server rendering each query also registers itself with
/// <c>IServerPrefetchFeature</c>, so the rendered markup waits for its data. On the client the
/// feature is absent and the registration is a no-op.
/// </para>
/// </remarks>
public static class NatrixQuery
{
    /// <summary>
    /// The client serving this part of the tree — the one a <c>QueryClientProvider</c>
    /// published, or the one the host registered.
    /// </summary>
    public static QueryClient UseQueryClient()
    {
        var features = AppFeatures.Current
            ?? throw new InvalidOperationException(
                "UseQueryClient can only be called while a component is being set up.");

        return features.Get<IQueryClientFeature>()?.Client
            ?? throw new InvalidOperationException(
                "No QueryClient is available. Register one with builder.UseQueryClient(...) during host " +
                "setup, or wrap the subtree in a QueryClientProvider component.");
    }

    /// <summary>
    /// Subscribes the component to a query, fetching it when needed and keeping it up to date.
    /// </summary>
    /// <example>
    /// <code>
    /// var todos = UseQuery(new UseQueryOptions&lt;Todo[]&gt;
    /// {
    ///     QueryKey = ["todos"],
    ///     QueryFn = ctx => api.GetTodosAsync(ctx.Signal),
    /// });
    /// </code>
    /// </example>
    public static UseQueryResult<TQueryFnData> UseQuery<TQueryFnData>(
        UseQueryOptions<TQueryFnData> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseQuery(() => options, client);
    }

    /// <summary>
    /// Subscribes the component to a query whose options are reactive: the factory re-runs
    /// whenever a signal it reads changes, and the query reconfigures itself — a new key moves
    /// it to another cache entry, a flipped <c>Enabled</c> starts or stops it.
    /// </summary>
    /// <example>
    /// <code>
    /// var todo = UseQuery(() => new UseQueryOptions&lt;Todo&gt;
    /// {
    ///     QueryKey = ["todos", selectedId.Value],
    ///     QueryFn = ctx => api.GetTodoAsync(selectedId.Value, ctx.Signal),
    ///     Enabled = selectedId.Value is not null,
    /// });
    /// </code>
    /// </example>
    public static UseQueryResult<TQueryFnData> UseQuery<TQueryFnData>(
        Func<UseQueryOptions<TQueryFnData>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseQueryCore<TQueryFnData, TQueryFnData>(optionsFactory, client);
    }

    /// <summary>
    /// Subscribes the component to a query and projects its data through
    /// <see cref="UseQueryOptions{TQueryFnData, TData}.Select"/>.
    /// </summary>
    public static UseQueryResult<TData> UseQuery<TQueryFnData, TData>(
        UseQueryOptions<TQueryFnData, TData> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseQuery(() => options, client);
    }

    /// <summary>
    /// Subscribes the component to a query with reactive options and projects its data through
    /// <see cref="UseQueryOptions{TQueryFnData, TData}.Select"/>.
    /// </summary>
    public static UseQueryResult<TData> UseQuery<TQueryFnData, TData>(
        Func<UseQueryOptions<TQueryFnData, TData>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseQueryCore<TQueryFnData, TData>(optionsFactory, client);
    }

    /// <summary>
    /// Subscribes the component to a list of queries whose length may change — the case a
    /// fixed set of <see cref="UseQuery{TQueryFnData}(UseQueryOptions{TQueryFnData}, QueryClient?)"/>
    /// calls cannot express. Queries that stay in the list across changes keep their data.
    /// </summary>
    /// <example>
    /// <code>
    /// var todos = UseQueries(() => selectedIds.Value
    ///     .Select(id => new UseQueryOptions&lt;Todo&gt;
    ///     {
    ///         QueryKey = ["todos", id],
    ///         QueryFn = ctx => api.GetTodoAsync(id, ctx.Signal),
    ///     })
    ///     .ToArray());
    /// </code>
    /// </example>
    public static IReadOnlySignal<IReadOnlyList<QueryObserverResult<TQueryFnData>>> UseQueries<TQueryFnData>(
        Func<IReadOnlyList<UseQueryOptions<TQueryFnData>>> queriesFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(queriesFactory);

        var queryClient = client ?? UseQueryClient();

        QueriesObserver<TQueryFnData>? observer = null;
        Signal<IReadOnlyList<QueryObserverResult<TQueryFnData>>>? results = null;
        IDisposable? subscription = null;

        new Effect(_ =>
        {
            var queries = queriesFactory();

            if (observer is null)
            {
                observer = new QueriesObserver<TQueryFnData>(queryClient, queries);

                var resultsSignal = new Signal<IReadOnlyList<QueryObserverResult<TQueryFnData>>>(
                    observer.CurrentResults);
                results = resultsSignal;

                subscription = observer.Subscribe(next => resultsSignal.Value = next);
                resultsSignal.Value = observer.CurrentResults;
            }
            else
            {
                observer.SetQueries(queries);
            }
        });

        new Effect(onCleanup => onCleanup(() =>
        {
            subscription?.Dispose();
            observer?.Dispose();
        }));

        RegisterServerPrefetch(async () =>
        {
            if (observer is null)
            {
                return;
            }

            await Task.WhenAll(observer.Observers.Select(o => o.SuspenseAsync())).ConfigureAwait(true);
        });

        return results!;
    }

    /// <summary>
    /// How many queries are fetching right now — the global loading indicator in one line.
    /// </summary>
    public static IReadOnlySignal<int> UseIsFetching(QueryFilters? filters = null, QueryClient? client = null)
    {
        var queryClient = client ?? UseQueryClient();

        var count = new Signal<int>(queryClient.IsFetching(filters));
        var subscription = queryClient.QueryCache.Subscribe(_ => count.Value = queryClient.IsFetching(filters));

        new Effect(onCleanup => onCleanup(subscription.Dispose));

        return count;
    }

    private static UseQueryResult<TData> UseQueryCore<TQueryFnData, TData>(
        Func<UseQueryOptions<TQueryFnData, TData>> optionsFactory,
        QueryClient? client)
    {
        var queryClient = client ?? UseQueryClient();

        QueryObserver<TQueryFnData, TData>? observer = null;
        Signal<QueryObserverResult<TData>>? result = null;
        IDisposable? subscription = null;

        // The options are evaluated inside an effect, which is what makes every option
        // reactive: whatever signals the factory reads become dependencies, and a change
        // re-runs it and reconfigures the observer.
        new Effect(_ =>
        {
            var options = optionsFactory();

            if (observer is null)
            {
                observer = new QueryObserver<TQueryFnData, TData>(queryClient, options);

                var resultSignal = new Signal<QueryObserverResult<TData>>(observer.CurrentResult);
                result = resultSignal;

                // Subscribing is what attaches the observer to its query and starts the mount
                // fetch, so anything it produces synchronously lands in the signal below.
                subscription = observer.Subscribe(next => resultSignal.Value = next);
                resultSignal.Value = observer.CurrentResult;
            }
            else
            {
                observer.SetOptions(options);
            }
        });

        // A separate effect with no dependencies: its cleanup runs once, when the component's
        // scope is disposed, rather than on every options change.
        new Effect(onCleanup => onCleanup(() =>
        {
            subscription?.Dispose();
            observer?.Dispose();
        }));

        RegisterServerPrefetch(async () =>
        {
            if (observer is not null)
            {
                await observer.SuspenseAsync().ConfigureAwait(true);
            }
        });

        return new UseQueryResult<TData>(
            result!,
            options => observer!.RefetchAsync(options),
            () => observer!.SuspenseAsync());
    }

    private static void RegisterServerPrefetch(Func<Task> prefetch)
    {
        // Absent on the client, where nothing waits for data before rendering.
        AppFeatures.Current?.OnServerPrefetch(prefetch);
    }
}
