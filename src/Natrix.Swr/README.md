# Natrix.Swr

Data fetching for Natrix components, ported from [React SWR](https://swr.vercel.app/).

The name is the strategy: **s**tale-**w**hile-**r**evalidate. A component asks for a key, gets
whatever is already cached for it straight away, and a request runs in the background to replace
it. Components asking for the same key share one request and one value.

```bash
dotnet add package Natrix.Swr
```

## Setup

Register a cache on the host before mounting. There is no ambient default — a process-wide cache
would be the wrong thing on a server rendering one visitor's request after another.

```csharp
using Natrix.Swr;

using var app = new NatrixHostBuilder()
    .UseRootElement(rootElement)
    .UseLifecycleHooks()
    .UseSwr()
    .UseRootComponent(() => new App { Props = new() })
    .Build()
    .Mount();
```

## Fetching

Call `SwrResource.Use` from a component's `Setup` and render from the signals it returns.

```csharp
public sealed class UserCard : BaseComponent<UserCardProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var user = SwrResource.Use(
            () => ["user", Props.UserId.Value],
            async (key, ct) => await api.GetUserAsync(key[1], ct));

        return
        [
            new If
            {
                Condition = user.IsLoading,
                Then = () => [new Spinner { Props = new() }],
                Otherwise = () =>
                [
                    new DomText { Text = new Computed<string>(() => user.Data.Value?.Name ?? "—") },
                ],
            },
        ];
    }
}
```

### Keys

A key is a list of string segments, built with a collection expression:

```csharp
SwrKey key = ["user", userId, "posts"];
```

Segments are encoded length-prefixed, so `["ab", "c"]` and `["abc"]` are different keys and no
segment value can collide with another key by containing a separator.

Pass a `Func<SwrKey>` when part of the key is reactive. Signals read inside are tracked, so the
resource follows them: when the key changes it rebinds, shows whatever is cached for the new key,
and refetches. A factory that re-runs and produces the *same* key changes nothing.

```csharp
var posts = SwrResource.Use(
    () => ["user", userId.Value, "posts"],
    (key, ct) => api.GetPostsAsync(key[1], ct));
```

Return `SwrKey.None` to pause — the equivalent of React SWR's `null` key. A paused resource never
fetches and reports no data, which is how a request that depends on something not ready yet is
expressed:

```csharp
var user = SwrResource.Use(
    () => session.Value is { } s ? new SwrKey("user", s.UserId) : SwrKey.None,
    (key, ct) => api.GetUserAsync(key[1], ct));
```

The fetcher is handed the key it is loading. Read the parameters back out of it rather than
closing over signals, so the request can never disagree with the key its result is cached under.

### What you get back

| Member | Meaning |
| --- | --- |
| `Data` | Cached value for the current key, `default` until one arrives. Stays put across revalidations and failures. |
| `Error` | Last error, cleared by the next successful fetch. |
| `IsLoading` | Nothing to show yet: no value and no error for this key. |
| `IsValidating` | A request is in flight, retries included. Also true while refreshing data already on screen. |
| `Key` | The key currently bound. |
| `RevalidateAsync()` | Refetches, or joins the request already running. |
| `MutateAsync(value)` | Writes a value into the cache — every component on that key updates — and refetches to confirm it. |
| `MutateAsync(update)` | Same, deriving the new value from the current one. |

`MutateAsync` cancels whatever request is in flight first: a response already on its way describes
the state *before* the mutation, and letting it land would undo it.

```csharp
await todos.MutateAsync(current => [.. current ?? [], newTodo], revalidate: false);
```

## Options

This port covers error retries and nothing else. React SWR's refresh intervals,
revalidate-on-focus, deduping windows and fallback data are deliberately absent rather than
half-implemented.

| Option | Default | Meaning |
| --- | --- | --- |
| `ShouldRetryOnError` | `true` | Whether a failed fetch is retried at all. |
| `ErrorRetryCount` | `3` | Additional attempts after the first failure. React SWR retries forever; a bound is the safer default in a browser tab. |
| `ErrorRetryInterval` | `5s` | Base backoff. Attempt *n* waits `ErrorRetryInterval * 2^n`, capped at 2^8, without jitter. |

Set them per resource, or app-wide as the default:

```csharp
builder.UseSwr(new SwrOptions { ErrorRetryCount = 5 });

var user = SwrResource.Use(key, fetcher, new SwrOptions { ShouldRetryOnError = false });
```

`Error` is published as soon as an attempt fails, while retries may still be pending —
`IsValidating` stays true for the whole sequence.

## Behaviour worth knowing

**Nothing is fetched during `Setup`.** The first request goes out from an `OnMounted` hook. On the
server, where lifecycle hooks are dropped because there is no live tree, that means SSR renders
the loading state and the client fetches after hydration — which is also what keeps hydration
consistent, since the client's first render happens before mounted hooks flush and therefore
matches the server's markup.

**Requests are deduplicated while in flight.** Ten components mounting on the same key issue one
request. There is no time-based deduping window: once a request finishes, the next revalidation
starts a new one.

**The cache outlives components.** Unmounting releases a component's claim on an entry but keeps
its value, so remounting renders immediately and revalidates in the background. When the last
component watching a key goes away, its in-flight request and any queued retry are cancelled — the
fetcher's `CancellationToken` fires.

**Entries are never evicted automatically.** Call `SwrCache.Remove(key)` or `SwrCache.Clear()` for
keys that must not accumulate or must not survive a sign-out. Components currently bound to a
removed key keep showing what they have until their key changes or they unmount; the next
component to ask for it starts fresh.

**Signals are not thread-safe**, and neither is this. Continuations are resumed on the
synchronization context the request started on, which in a browser is the single UI thread.
