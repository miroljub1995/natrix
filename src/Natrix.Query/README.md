# Natrix.Query

Asynchronous server-state management for [Natrix](https://github.com/miroljub1995/natrix) —
a port of [TanStack Query](https://tanstack.com/query/latest/docs/framework/vue/guides/queries)
built on Natrix signals. Caching, deduplication, background refetching, retries with backoff,
window-focus and reconnect revalidation, polling, garbage collection, infinite queries, and
mutations with optimistic updates.

The API follows the Vue Query surface closely: `UseQuery`, `UseQueries`, `UseInfiniteQuery`,
`UseMutation`, `UseIsFetching`, `UseIsMutating`, `UseMutationState`, `UseQueryClient`, a
`QueryClient` with the same methods, and the same option names and defaults.

## Getting started

Register a client during host setup, then query from any component's `Setup`:

```csharp
using Natrix.Query;

new NatrixHostBuilder()
    .UseRootElement(appElement)
    .UseLifecycleHooks()
    .UseQueryClient(new QueryClient())
    .UseRootComponent(() => new App { Props = new AppProps() })
    .Build()
    .Mount();
```

```csharp
using static Natrix.Query.NatrixQuery;

public class TodoList : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var todos = UseQuery(new UseQueryOptions<Todo[]>
        {
            QueryKey = ["todos"],
            QueryFn = ctx => api.GetTodosAsync(ctx.Signal),
        });

        return
        [
            new If
            {
                Condition = todos.IsPending,
                Then = () => [new Span { Children = [new DomText { Text = "Loading…".ToConstSignal() }] }],
                Otherwise = () => [/* render todos.Data.Value */],
            },
        ];
    }
}
```

Every field of the result is its own signal, so a component that renders `Data` is not re-run
when `FailureCount` ticks during a retry. That granularity is why Vue Query's
`notifyOnChangeProps` has no counterpart here.

## Status and fetch status

The two are orthogonal, exactly as in TanStack Query:

| `Status`  | meaning                       | `FetchStatus` | meaning                                  |
| --------- | ----------------------------- | ------------- | ---------------------------------------- |
| `Pending` | no data yet                   | `Fetching`    | the query function is running            |
| `Error`   | the query threw               | `Paused`      | offline; the fetch resumes on reconnect  |
| `Success` | data is available             | `Idle`        | nothing is happening                     |

`IsLoading` — pending *and* fetching — is what a spinner should key off; a disabled or paused
query is pending with nothing on its way. `IsRefetching` is a background fetch on top of data
that is already on screen.

## Query keys

A key is a collection expression, and anything serializable can be a segment:

```csharp
QueryKey key = ["todos", todoId, new Dictionary<string, object?> { ["page"] = 1 }];
```

Keys are compared by a deterministic hash, so dictionary entry order never affects identity.
Primitives, strings, enums, `Guid`, dates, records, tuples, sequences and string-keyed
dictionaries all work; a type that does not override `ToString()` is rejected rather than
silently colliding with every other instance of itself.

Filters use prefix matching, so `["todos"]` selects `["todos", 1]` too:

```csharp
await client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
```

## Reactive options

Pass a factory and every option becomes reactive — the query reconfigures itself whenever a
signal the factory reads changes. This is how dependent and parameterised queries are written:

```csharp
var todo = UseQuery(() => new UseQueryOptions<Todo>
{
    QueryKey = ["todos", selectedId.Value],
    QueryFn = ctx => api.GetTodoAsync(selectedId.Value!.Value, ctx.Signal),
    Enabled = selectedId.Value is not null,
    PlaceholderData = PlaceholderDataOption<Todo>.KeepPreviousData,
});
```

## Mutations

Reads are queries; writes are mutations. Nothing runs until you fire one, and nothing is cached
by key — what the result tracks is the run in flight and the one before it:

```csharp
var client = UseQueryClient();

var addTodo = UseMutation(new UseMutationOptions<Todo, string>
{
    MutationFn = title => api.CreateTodoAsync(title),
    OnSettled = (_, _, _, _) =>
        client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] }),
});

// from an event handler — Mutate never throws; the outcome lands in the signals
addTodo.Mutate("buy milk");

// or await it, and handle failure yourself
var todo = await addTodo.MutateAsync("buy milk");
```

`OnMutate` runs first and its return value becomes the context every other callback receives,
which is what an optimistic update rolls back to:

```csharp
var toggle = UseMutation(new UseMutationOptions<Todo, int, Todo[]?>
{
    MutationFn = id => api.ToggleAsync(id),
    OnMutate = async id =>
    {
        await client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
        var previous = client.GetQueryData<Todo[]>(["todos"]);
        client.SetQueryData<Todo[]>(["todos"], todos => Toggled(todos, id));
        return previous;
    },
    OnError = (_, _, previous) =>
    {
        client.SetQueryData<Todo[]>(["todos"], previous);
        return Task.CompletedTask;
    },
    OnSettled = (_, _, _, _) =>
        client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] }),
});
```

A mutation fired while offline pauses instead of failing, and resumes when the connection
returns — automatically for a live client, or through `ResumePausedMutationsAsync` for one
restored from a dehydrated snapshot. Give two mutations the same `Scope` and they queue instead
of racing. `UseIsMutating()` counts what is in flight, and `UseMutationState(…)` projects the
state of each — the variables of everything currently saving, wherever it was fired from.

## Infinite queries

A list that grows a page at a time lives in one cache entry, under one key:

```csharp
var projects = UseInfiniteQuery(new UseInfiniteQueryOptions<ProjectPage, int>
{
    QueryKey = ["projects"],
    InitialPageParam = 0,
    QueryFn = ctx => api.GetProjectsAsync(ctx.PageParam, ctx.Signal),
    GetNextPageParam = (lastPage, _, _, _) => lastPage.NextCursor is { } next
        ? next
        : NextPageParam<int>.None,
});

// projects.Pages.Value.Pages   — every page fetched so far
// projects.HasNextPage.Value   — whether "load more" has anything to load
// projects.IsFetchingNextPage  — a "load more" specifically, not a refetch
await projects.FetchNextPageAsync();
```

Refetching replays every page it already had, in order, so the list refreshes rather than
collapsing back to its first page. `MaxPages` bounds it, `GetPreviousPageParam` lets it grow
upwards too, and `Select` flattens the pages into whatever the component actually renders.

## The client

`UseQueryClient()` returns the client serving the current subtree; everything TanStack Query
offers imperatively is on it:

```csharp
client.GetQueryData<Todo[]>(["todos"]);
client.SetQueryData<Todo[]>(["todos"], todos => [.. todos ?? [], created]);
await client.InvalidateQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
await client.PrefetchQueryAsync(new UseQueryOptions<Todo[]> { QueryKey = ["todos"], QueryFn = … });
await client.CancelQueriesAsync(new QueryFilters { QueryKey = ["todos"] });
client.RemoveQueries(new QueryFilters { QueryKey = ["todos"] });
```

Infinite queries have their own imperative forms — `FetchInfiniteQueryAsync`,
`PrefetchInfiniteQueryAsync` and `EnsureInfiniteQueryDataAsync`, each taking how many pages to
load up front.

Scope a different client to part of the tree with the `QueryClientProvider` component.

## Global callbacks

Handling every failure the same way belongs on the cache, not on each query. This is what the
`Meta` option is for — it carries whatever the shared handler needs to say:

```csharp
var client = new QueryClient(new QueryClientConfig
{
    QueryCache = new QueryCache(new QueryCacheConfig
    {
        OnError = (error, query) => toasts.Show(query.Meta?["errorMessage"] as string ?? error.Message),
    }),
    MutationCache = new MutationCache(new MutationCacheConfig
    {
        OnError = (error, _, _, _) => { toasts.Show(error.Message); return Task.CompletedTask; },
    }),
});
```

Cancelling a query is not a failure, so it never reaches these handlers. The mutation ones are
awaited, and each runs before the mutation's own callback of the same name.

## Server-side rendering

Queries register themselves with `IServerPrefetchFeature`, so a server-rendered page waits for
its data before producing markup — no extra wiring. Move the resulting cache to the client with
`Hydration.Dehydrate` / `Hydration.Hydrate`, serializing the snapshot with your own serializer.
The same pair carries mutations that paused offline: the snapshot holds their variables, and the
receiving client supplies the function through `SetMutationDefaults`.

## Differences from TanStack Query

- **No `undefined`.** C# has only `null`, so "no data" is tracked explicitly: `HasData` on the
  state and the result, and `null` from a `SetQueryData` updater means "leave the cache alone".
- **Structural sharing keeps references rather than rebuilding trees.** Equal incoming data
  keeps the cached reference; TanStack Query's partial `replaceEqualDeep` needs runtime
  reflection over arbitrary objects, which a trimmed AOT assembly cannot do. Supply
  `StructuralSharingFn` for a specific shape.
- **`Select` must be present when the observed type differs** from what the query function
  returns; there is no structural typing to fall back on.
- **No `notifyOnChangeProps`.** Signals already deliver per-field subscriptions.
- **"No more pages" is `NextPageParam<T>.None`**, not `null`. A cursor is often an `int` or a
  `DateTime`, where `0` and `default` are perfectly good page params, so the absence has to be
  its own value.
- **Mutation callbacks return `Task`.** They are awaited before the mutation counts as settled
  — which is the point, since `OnSettled` usually awaits an invalidation.
- **Cancellation is a `CancellationToken`** (`ctx.Signal`) rather than an `AbortSignal`, and
  reading it marks the query function as honouring cancellation, exactly as TanStack Query
  watches for access to `signal`.

## Threading

The engine assumes the single-threaded model the browser gives it: continuations are never
detached from the calling context, and timer callbacks are posted back to the
`SynchronizationContext` that scheduled them. On the server, run rendering inside
`ISsrConcurrencyGateFeature` as Natrix already does. Substitute the clock through
`QueryClientConfig.TimeProvider` to drive staleness, polling and backoff in tests.
