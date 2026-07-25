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
using Natrix.Docs.Components;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapStaticAssets();

app.MapFallback(async (httpContext) =>
{
    var requestPath = httpContext.Request.Path.Value ?? "/";
    var navigation = new ServerNavigationFeature(requestPath);
    var root = new SsrRenderRoot();
    var prefetch = new ServerPrefetchFeature();

    using var _ = new NatrixHostBuilder()
        .UseRootRenderer(root)
        .UseTeleport()
        .SetFeature<IServerPrefetchFeature>(prefetch)
        .SetFeature<IServerHydrationStateFeature>(new ServerHydrationStateFeature())
        .SetFeature<INavigationFeature>(navigation)
        .SetFeature(httpContext)
        .UseRootComponent(() => new DocsPage { Props = new DocsPageProps() })
        .Build()
        .Mount();

    await prefetch.WaitForCompletionAsync(httpContext.RequestAborted);

    if (navigation.RedirectLocation is { } location)
    {
        httpContext.Response.Redirect(location);
        return;
    }

    httpContext.Response.Headers.ContentType = "text/html";
    await httpContext.Response.BodyWriter.WriteAsync(Encoding.UTF8.GetBytes("<!DOCTYPE html>"));
    await root.WriteAsync(httpContext.Response.BodyWriter, cancellationToken: httpContext.RequestAborted);
    await httpContext.Response.BodyWriter.FlushAsync(httpContext.RequestAborted);
});

app.Run();
