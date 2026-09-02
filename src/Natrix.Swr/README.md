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
    .SetFeature(serializerOptions)
    .UseSwr()
    .UseRootComponent(() => new App { Props = new() })
    .Build()
    .Mount();
```

Serializer options are required: they are what carries a value from the server's render into the
page the browser hydrates from, described under [Server rendering](#server-rendering). They are
taken from the `JsonSerializerOptions` registered as a feature, so an application that already
configures serialization does not hand SWR the same thing twice; pass `UseSwr(serializerOptions: …)`
to override. With neither, `Mount()` says so.

`UseSwr` registers middleware rather than a feature, and the cache it builds is published to the
component tree at mount. That ordering is the point: the cache is built *out of* other features —
the serializer options, and whichever side of the hydration boundary this host is on — and
registration happens while the application is still being described, in an order nothing
guarantees. `UseSwr` can therefore go anywhere in the chain. If you need the cache yourself, build
it and pass it in:

```csharp
var cache = new SwrCache(serializerOptions);
builder.UseSwr(cache: cache);
```

A fetched type the options cannot describe is reported the same way, at the `Use` call that
introduced it rather than at the render that would have shipped it.

## Fetching

Call `SwrResource.Use` from a component's `Setup` and render from the signals it returns.

```csharp
public sealed class UserCard : BaseComponent<UserCardProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var user = SwrResource.Use(
            () => ("user", Props.UserId.Value),
            async (key, ct) => await api.GetUserAsync(key.Item2, ct));

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

A key is an ordered list of typed segments. Return a tuple of up to seven of them and the types
flow through to the fetcher, which reads its parameters back as what they were:

```csharp
var posts = SwrResource.Use(
    () => ("user", userId.Value, "posts"),
    (key, ct) => api.GetPostsAsync(key.Item2, ct));
```

Signals read inside the factory are tracked, so the resource follows them: when the key changes it
rebinds, shows whatever is cached for the new key, and refetches. A factory that re-runs and
produces the *same* key changes nothing.

A tuple has no absent value of its own, so pausing — the equivalent of React SWR's `null` key —
is spelled `null`. A paused resource never fetches and reports no data, which is how a request
that depends on something not ready yet is expressed. Name the type arguments, since a conditional
with `null` in it gives the compiler nothing to infer them from:

```csharp
var user = SwrResource.Use<string, string, User>(
    () => session.Value is { } s ? ("user", s.UserId) : null,
    (key, ct) => api.GetUserAsync(key.Item2, ct));
```

Overloads taking a `SwrKey` remain for keys whose arity or types are not known at the call. There
the fetcher reads segments by position — `key.Segment<string>(1)` — and pauses with `SwrKey.None`.
A key of plain strings can still be written as a collection expression:

```csharp
SwrKey key = ["user", userId, "posts"];
```

#### How keys become cache entries

A key is filed under a canonical JSON encoding of its segments, so `["ab", "c"]` and `["abc"]` are
different keys and no segment value can collide with another key by containing a separator.

The encoding takes the contracts for your own types from the `JsonSerializerOptions` below, but
none of their formatting: it fixes the naming policy, the encoder, number handling and null
handling itself, and sorts object properties. That is deliberate. A serializer guarantees a value
survives a round trip — not that two values encode alike exactly when they are equal, which is the
opposite property and the one an identity needs. Left to an application's own options, hiding nulls
would make two different keys collide, a naming policy that differs between the server and the
browser would hide the whole hydration payload, and a dictionary built in a different order would
become a second cache entry.

Segment types the library covers — the primitives, `Guid`, the date and time types, `Uri` — need no
registration. Anything else needs `[JsonSerializable]` on the shared context, and a typed `Use`
reports a missing one at the call — including for a key that starts out paused, which has no
segments to encode yet and would otherwise fail from whatever later unpauses it.

The fetcher is handed the key it is loading. Read the parameters back out of it rather than
closing over signals, so the request can never disagree with the key its result is cached under.

That rule is about what *identifies* the data. Ambient conditions the request happens to run
under — an auth token, a base address, whether the service is currently up — are not part of a
key: an outage does not change which user you asked for, and keying it would make the same user
into two cache entries. The test is whether the thing you are tempted to leave out could ever
produce a *different value* for the same key. If it could, it identifies the data and belongs in
the key; if it can only change whether the request succeeds, it does not.

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

Set the defaults app-wide, and adjust them per resource through a callback that receives them:

```csharp
builder.UseSwr(new SwrOptions { ErrorRetryCount = 5 });

var user = SwrResource.Use(key, fetcher, options => options with { ShouldRetryOnError = false });
```

The callback shape is deliberate. Handing `Use` a whole `SwrOptions` would replace the
application's defaults rather than layer on them, so a resource that only meant to change the retry
count would silently take `ShouldRetryOnError`, `ErrorRetryInterval` and anything added later from
the type's own defaults instead of the app's.

`Error` is published as soon as an attempt fails, while retries may still be pending —
`IsValidating` stays true for the whole sequence.

## Behaviour worth knowing

**Nothing is fetched during `Setup`.** In the browser the first request goes out from an
`OnMounted` hook, so a component that is set up and thrown away before it mounts costs nothing.

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

## Server rendering

A server-rendered page arrives with its data already in it, and the browser fetches nothing to
display the first screen.

Binding a key during server rendering registers a prefetch with `IServerPrefetchFeature`, which the
SSR host drains before it writes the response. The values land in that request's cache, the markup
is rendered from them, and the cache is serialized into the page's hydration state. On the client
the cache is seeded from that payload before the first component binds, so the first render matches
the server's markup and no revalidation is issued for data that arrived with the page.

Both hosts need the same serializer context, which is why the fetched types belong in a project the
client and the server both reference:

```csharp
[JsonSerializable(typeof(UserProfile))]
public sealed partial class AppJsonContext : JsonSerializerContext;
```

Source-generated metadata is what keeps the transfer working under the client's trimming and AOT
compilation. A type the context does not cover is reported at the `Use` call that introduced it,
not at render time.

Put that context in the resolver chain of each host's options and register those options as a
feature. On a server that already serves JSON, the options its own endpoints use are the ones to
register, so nothing in the render can disagree with what the browser will read:

```csharp
// Server
builder.Services.ConfigureHttpJsonOptions(options =>
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonContext.Default));

var serializerOptions = httpContext.RequestServices
    .GetRequiredService<IOptions<JsonOptions>>().Value.SerializerOptions;

// Client — web defaults, because that is what the server's options start from. The chain settles
// which types can be resolved and carries whatever converters the generator baked in; naming
// policy and case sensitivity belong to the options themselves, so both sides have to agree on
// them separately or every property silently reads as null.
var serializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    TypeInfoResolverChain = { AppJsonContext.Default },
};
```

The fetcher runs on both sides, so it has to be able to reach the API from both. In the browser that
usually means a relative URL against the page's origin; on the server, an absolute one built from
the request being answered.

Rules the transfer follows:

- **A key that fails on the server is left to the client.** Its entry is reset, so the server
  renders the loading state and the client fetches and retries it normally. Errors are never
  serialized into the page.
- **Server prefetches do not retry.** A failing upstream would otherwise hold the response open for
  the whole backoff sequence. The client retries per its options instead.
- **Two components on one key cost one prefetch.** The drain runs callbacks one at a time, so a
  prefetch checks for a value before requesting one rather than relying on in-flight deduplication.
- **Hydration freshness lasts for the page that carried it.** Data that arrived with the page is not
  revalidated on mount. Once the components holding that key unmount, it is ordinary stale cache
  again and the next mount revalidates it. An explicit `RevalidateAsync()` always fetches.
