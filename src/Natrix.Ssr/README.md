# Natrix.Ssr

Server-side rendering helpers for Natrix applications hosted on ASP.NET Core.

## Features

- `SsrEventLoop` runs a request the way the browser runs the app: one single-threaded event
  loop per request. Wrap the whole request handler in `SsrEventLoop.RunAsync` — mount, waiting
  for prefetches, and writing the response. Continuations run one at a time on it, which is what
  keeps the lock-free signals safe while prefetches run concurrently on the network.
- `ServerPrefetchFeature` starts every prefetch components register during `Setup` and waits
  for all of them, cascades included. Construct it with `HttpContext.RequestAborted` so an
  aborted request cancels its fetches.
- `MainScript` component that resolves the fingerprinted `_framework/dotnet.js` static asset route from endpoint metadata.

## Usage

Reference `Natrix.Ssr` from your server project and use components from `Natrix.Ssr.Components`.

```csharp
app.MapFallback(httpContext => SsrEventLoop.RunAsync(async () =>
{
    var root = new SsrRenderRoot();
    var prefetch = new ServerPrefetchFeature(httpContext.RequestAborted);

    using var _ = new NatrixHostBuilder()
        .UseRootRenderer(root)
        .SetFeature<IServerPrefetchFeature>(prefetch)
        .UseRootComponent(() => new AppPage())
        .Build()
        .Mount();

    await prefetch.WaitForCompletionAsync();

    httpContext.Response.Headers.ContentType = "text/html";
    await root.WriteAsync(httpContext.Response.BodyWriter, cancellationToken: httpContext.RequestAborted);
}));
```

The same rule as in the browser applies inside the loop: never block synchronously on a task
whose continuation has to come back through it.
