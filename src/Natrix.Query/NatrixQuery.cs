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
    /// Subscribes the component to a query that accumulates pages, exposing what the list can
    /// still be extended with alongside the ordinary result.
    /// </summary>
    /// <example>
    /// <code>
    /// var projects = UseInfiniteQuery(new UseInfiniteQueryOptions&lt;ProjectPage, int&gt;
    /// {
    ///     QueryKey = ["projects"],
    ///     InitialPageParam = 0,
    ///     QueryFn = ctx => api.GetProjectsAsync(ctx.PageParam, ctx.Signal),
    ///     GetNextPageParam = (lastPage, _, _, _) => lastPage.NextCursor is { } next
    ///         ? next
    ///         : NextPageParam&lt;int&gt;.None,
    /// });
    ///
    /// // …and on a "load more" click, when HasNextPage says there is one:
    /// await projects.FetchNextPageAsync();
    /// </code>
    /// </example>
    public static UseInfiniteQueryResult<TPage, TPageParam, InfiniteData<TPage, TPageParam>> UseInfiniteQuery<TPage, TPageParam>(
        UseInfiniteQueryOptions<TPage, TPageParam> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseInfiniteQuery(() => options, client);
    }

    /// <summary>
    /// Subscribes the component to an infinite query whose options are reactive, so the list
    /// starts over when the key it depends on changes.
    /// </summary>
    public static UseInfiniteQueryResult<TPage, TPageParam, InfiniteData<TPage, TPageParam>> UseInfiniteQuery<TPage, TPageParam>(
        Func<UseInfiniteQueryOptions<TPage, TPageParam>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseInfiniteQueryCore<TPage, TPageParam, InfiniteData<TPage, TPageParam>>(optionsFactory, client);
    }

    /// <summary>
    /// Subscribes the component to an infinite query and projects the accumulated pages —
    /// flattening them into a single list, usually.
    /// </summary>
    public static UseInfiniteQueryResult<TPage, TPageParam, TData> UseInfiniteQuery<TPage, TPageParam, TData>(
        UseInfiniteQueryOptions<TPage, TPageParam, TData> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseInfiniteQuery(() => options, client);
    }

    /// <summary>
    /// Subscribes the component to an infinite query with reactive options and projects the
    /// accumulated pages.
    /// </summary>
    public static UseInfiniteQueryResult<TPage, TPageParam, TData> UseInfiniteQuery<TPage, TPageParam, TData>(
        Func<UseInfiniteQueryOptions<TPage, TPageParam, TData>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseInfiniteQueryCore(optionsFactory, client);
    }

    /// <summary>
    /// Gives the component a mutation to fire — a create, update or delete, as opposed to the
    /// reads <c>UseQuery</c> manages.
    /// </summary>
    /// <remarks>
    /// Nothing runs until <c>Mutate</c> is called, and nothing is cached by key: what the
    /// result tracks is the run in flight and the one before it.
    /// </remarks>
    /// <example>
    /// <code>
    /// var client = UseQueryClient();
    ///
    /// var addTodo = UseMutation(new UseMutationOptions&lt;Todo, string&gt;
    /// {
    ///     MutationFn = title => api.CreateTodoAsync(title),
    ///     OnSettled = (_, _, _, _) =>
    ///         client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] }),
    /// });
    ///
    /// // in a click handler:
    /// addTodo.Mutate("buy milk");
    /// </code>
    /// </example>
    public static UseMutationResult<TData, TVariables> UseMutation<TData, TVariables>(
        UseMutationOptions<TData, TVariables> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseMutation(() => options, client);
    }

    /// <summary>
    /// Gives the component a mutation whose options are reactive — the form to use when a
    /// callback closes over signals that change.
    /// </summary>
    public static UseMutationResult<TData, TVariables> UseMutation<TData, TVariables>(
        Func<UseMutationOptions<TData, TVariables>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseMutationCore<TData, TVariables, object>(optionsFactory, client);
    }

    /// <summary>
    /// Gives the component a mutation that carries a context from <c>OnMutate</c> through to
    /// its other callbacks — how an optimistic update remembers what to roll back to.
    /// </summary>
    /// <example>
    /// <code>
    /// var client = UseQueryClient();
    ///
    /// var toggle = UseMutation(new UseMutationOptions&lt;Todo, int, Todo[]?&gt;
    /// {
    ///     MutationFn = id => api.ToggleAsync(id),
    ///     OnMutate = async id =>
    ///     {
    ///         await client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
    ///         var previous = client.GetQueryData&lt;Todo[]&gt;(["todos"]);
    ///         client.SetQueryData&lt;Todo[]&gt;(["todos"], todos => Toggled(todos, id));
    ///         return previous;
    ///     },
    ///     OnError = (_, _, previous) =>
    ///     {
    ///         client.SetQueryData&lt;Todo[]&gt;(["todos"], previous);
    ///         return Task.CompletedTask;
    ///     },
    ///     OnSettled = (_, _, _, _) =>
    ///         client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] }),
    /// });
    /// </code>
    /// </example>
    public static UseMutationResult<TData, TVariables> UseMutation<TData, TVariables, TContext>(
        UseMutationOptions<TData, TVariables, TContext> options,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(options);
        return UseMutation(() => options, client);
    }

    /// <summary>
    /// Gives the component a mutation with reactive options that carries a context from
    /// <c>OnMutate</c> through to its other callbacks.
    /// </summary>
    public static UseMutationResult<TData, TVariables> UseMutation<TData, TVariables, TContext>(
        Func<UseMutationOptions<TData, TVariables, TContext>> optionsFactory,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(optionsFactory);
        return UseMutationCore(optionsFactory, client);
    }

    /// <summary>
    /// The state of every mutation matching <paramref name="filters"/>, projected through
    /// <paramref name="select"/>. What renders "3 items being saved" from the variables of the
    /// mutations in flight, wherever in the tree they were fired.
    /// </summary>
    /// <example>
    /// <code>
    /// var saving = UseMutationState(
    ///     state => (string?)state.Variables,
    ///     new MutationFilters { MutationKey = ["todos"], Status = MutationStatus.Pending });
    /// </code>
    /// </example>
    public static IReadOnlySignal<IReadOnlyList<TResult>> UseMutationState<TResult>(
        Func<MutationState, TResult> select,
        MutationFilters? filters = null,
        QueryClient? client = null)
    {
        ArgumentNullException.ThrowIfNull(select);

        var queryClient = client ?? UseQueryClient();

        IReadOnlyList<TResult> Current() => queryClient.MutationCache
            .FindAll(filters)
            .Select(mutation => select(mutation.State))
            .ToArray();

        var states = new Signal<IReadOnlyList<TResult>>(Current());
        var subscription = queryClient.MutationCache.Subscribe(_ => states.Value = Current());

        new Effect(onCleanup => onCleanup(subscription.Dispose));

        return states;
    }

    /// <summary>The state of every mutation matching <paramref name="filters"/>.</summary>
    public static IReadOnlySignal<IReadOnlyList<MutationState>> UseMutationState(
        MutationFilters? filters = null,
        QueryClient? client = null) =>
        UseMutationState(static state => state, filters, client);

    /// <summary>How many mutations are running right now.</summary>
    public static IReadOnlySignal<int> UseIsMutating(MutationFilters? filters = null, QueryClient? client = null)
    {
        var queryClient = client ?? UseQueryClient();

        var count = new Signal<int>(queryClient.IsMutating(filters));
        var subscription = queryClient.MutationCache.Subscribe(_ => count.Value = queryClient.IsMutating(filters));

        new Effect(onCleanup => onCleanup(subscription.Dispose));

        return count;
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

        var binding = Bind(
            optionsFactory,
            options => new QueryObserver<TQueryFnData, TData>(queryClient, options),
            static (observer, options) => observer.SetOptions(options));

        return new UseQueryResult<TData>(
            binding.Result,
            options => binding.Observer().RefetchAsync(options),
            () => binding.Observer().SuspenseAsync());
    }

    private static UseInfiniteQueryResult<TPage, TPageParam, TData> UseInfiniteQueryCore<TPage, TPageParam, TData>(
        Func<UseInfiniteQueryOptions<TPage, TPageParam, TData>> optionsFactory,
        QueryClient? client)
    {
        var queryClient = client ?? UseQueryClient();

        var binding = Bind<InfiniteData<TPage, TPageParam>, TData, UseInfiniteQueryOptions<TPage, TPageParam, TData>>(
            optionsFactory,
            options => new InfiniteQueryObserver<TPage, TPageParam, TData>(queryClient, options),
            static (observer, options) => ((InfiniteQueryObserver<TPage, TPageParam, TData>)observer).SetOptions(options));

        InfiniteQueryObserver<TPage, TPageParam, TData> Observer() =>
            (InfiniteQueryObserver<TPage, TPageParam, TData>)binding.Observer();

        return new UseInfiniteQueryResult<TPage, TPageParam, TData>(
            binding.Result,
            options => Observer().RefetchAsync(options),
            () => Observer().SuspenseAsync(),
            () => Observer().FetchNextPageAsync(),
            () => Observer().FetchPreviousPageAsync());
    }

    private static UseMutationResult<TData, TVariables> UseMutationCore<TData, TVariables, TContext>(
        Func<UseMutationOptions<TData, TVariables, TContext>> optionsFactory,
        QueryClient? client)
    {
        var queryClient = client ?? UseQueryClient();

        MutationObserver<TData, TVariables, TContext>? observer = null;
        Signal<MutationObserverResult<TData, TVariables>>? result = null;
        IDisposable? subscription = null;

        new Effect(_ =>
        {
            var options = optionsFactory();

            if (observer is null)
            {
                var created = new MutationObserver<TData, TVariables, TContext>(queryClient, options);
                observer = created;

                var resultSignal = new Signal<MutationObserverResult<TData, TVariables>>(created.CurrentResult);
                result = resultSignal;

                subscription = created.Subscribe(next => resultSignal.Value = next);
            }
            else
            {
                observer.SetOptions(options);
            }
        });

        new Effect(onCleanup => onCleanup(() =>
        {
            subscription?.Dispose();
            observer?.Dispose();
        }));

        return new UseMutationResult<TData, TVariables>(
            result!,
            (variables, mutateOptions) => observer!.Mutate(variables, mutateOptions),
            (variables, mutateOptions) => observer!.MutateAsync(variables, mutateOptions),
            () => observer!.Reset());
    }

    /// <summary>
    /// Creates the observer, republishes its results as a signal, and ties both to the
    /// component's scope. Shared by every query composable, which differ only in what kind of
    /// observer they build.
    /// </summary>
    private static ObserverBinding<TQueryFnData, TData> Bind<TQueryFnData, TData, TOptions>(
        Func<TOptions> optionsFactory,
        Func<TOptions, QueryObserver<TQueryFnData, TData>> create,
        Action<QueryObserver<TQueryFnData, TData>, TOptions> update)
    {
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
                var created = create(options);
                observer = created;

                var resultSignal = new Signal<QueryObserverResult<TData>>(created.CurrentResult);
                result = resultSignal;

                // Subscribing is what attaches the observer to its query and starts the mount
                // fetch, so anything it produces synchronously lands in the signal below.
                subscription = created.Subscribe(next => resultSignal.Value = next);
                resultSignal.Value = created.CurrentResult;
            }
            else
            {
                update(observer, options);
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

        return new ObserverBinding<TQueryFnData, TData>(result!, () => observer!);
    }

    /// <summary>The signal a composable publishes, and the observer behind it.</summary>
    private sealed record ObserverBinding<TQueryFnData, TData>(
        IReadOnlySignal<QueryObserverResult<TData>> Result,
        Func<QueryObserver<TQueryFnData, TData>> Observer);

    private static void RegisterServerPrefetch(Func<Task> prefetch)
    {
        // Absent on the client, where nothing waits for data before rendering.
        AppFeatures.Current?.OnServerPrefetch(prefetch);
    }
}
