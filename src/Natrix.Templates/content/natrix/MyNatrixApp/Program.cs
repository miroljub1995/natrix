using System.Text;
using Natrix.Core;
using Natrix.Core.Features;
using Natrix.Ssr;
using Natrix.Ssr.Abstractions.Features;
using Natrix.Ssr.Features;
using Natrix.Ssr.Features.Routing;
using Natrix.Ssr.Abstractions.Features.HydrationState;
using Natrix.Ssr.Features.HydrationState;
using Natrix.Core.Features.Routing;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.RenderRoot;
using MyNatrixApp.Components;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapStaticAssets();

// The whole request runs on one SsrEventLoop: mount, the prefetches components start, and the
// response. The loop runs continuations one at a time, which is what lets the prefetches run
// concurrently while the render stays single-threaded, as it is in the browser.
app.MapFallback(httpContext => SsrEventLoop.RunAsync(async () =>
{
    var requestPath = httpContext.Request.Path.Value ?? "/";
    var navigation = new ServerNavigationFeature(requestPath);
    var root = new SsrRenderRoot();
    var prefetch = new ServerPrefetchFeature(httpContext.RequestAborted);

    using var _ = new NatrixHostBuilder()
        .UseRootRenderer(root)
        .UseTeleport()
        .SetFeature<IServerPrefetchFeature>(prefetch)
        .SetFeature<IServerHydrationStateFeature>(new ServerHydrationStateFeature())
        .SetFeature<INavigationFeature>(navigation)
        .SetFeature(httpContext)
        .UseRootComponent(() => new AppPage { Props = new AppPageProps() })
        .Build()
        .Mount();

    await prefetch.WaitForCompletionAsync();

    if (navigation.RedirectLocation is { } location)
    {
        httpContext.Response.Redirect(location);
        return;
    }

    httpContext.Response.Headers.ContentType = "text/html; charset=utf-8";
    await httpContext.Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes("<!DOCTYPE html>"));
    await root.WriteAsync(httpContext.Response.BodyWriter, cancellationToken: httpContext.RequestAborted);
    await httpContext.Response.BodyWriter.FlushAsync(httpContext.RequestAborted);
}));

app.Run();
