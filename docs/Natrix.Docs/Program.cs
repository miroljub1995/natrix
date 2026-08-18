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
using Natrix.Docs.Client.Components.Examples.DataFetching;
using Natrix.Docs.Components;
using Natrix.Docs.Contracts;
using Natrix.Swr;

var builder = WebApplication.CreateBuilder(args);

// Pooled handlers: server-side rendering calls the app's own endpoint once per request, and a
// fresh HttpClient per request would exhaust sockets under load.
builder.Services.AddHttpClient();

var app = builder.Build();

app.MapStaticAssets();

// The endpoint the data fetching example reads, deliberately slow enough that the loading and
// revalidating states are visible.
var users = new Dictionary<string, UserProfile>(StringComparer.OrdinalIgnoreCase)
{
    ["ada"] = new("Ada Lovelace", "Mathematician", 1843),
    ["grace"] = new("Grace Hopper", "Rear Admiral", 1959),
    ["linus"] = new("Linus Torvalds", "Kernel maintainer", 1991),
};

app.MapGet("/api/users/{id}", async (string id, string? fail, CancellationToken cancellationToken) =>
{
    await Task.Delay(TimeSpan.FromMilliseconds(500), cancellationToken);

    if (fail == "1")
    {
        return Results.StatusCode(StatusCodes.Status503ServiceUnavailable);
    }

    return users.TryGetValue(id, out var profile)
        ? Results.Json(profile, DocsJsonContext.Default.UserProfile)
        : Results.NotFound();
});

app.MapFallback(async (httpContext) =>
{
    var requestPath = httpContext.Request.Path.Value ?? "/";

    // Resolved from the request being answered, so server-side fetching reaches the same endpoint
    // the browser would, whatever host and scheme the app is served under.
    var httpClient = httpContext.RequestServices.GetRequiredService<IHttpClientFactory>().CreateClient();
    httpClient.BaseAddress = new Uri($"{httpContext.Request.Scheme}://{httpContext.Request.Host}/");
    var navigation = new ServerNavigationFeature(requestPath);
    var root = new SsrRenderRoot();
    var prefetch = new ServerPrefetchFeature();

    using var _ = new NatrixHostBuilder()
        .UseRootRenderer(root)
        .UseTeleport()
        // A cache per request - never a shared one, which would hand one visitor's data to the
        // next. Resources prefetch into it while the tree renders, and it is serialized into the
        // page so the client picks the values up instead of fetching them again.
        .UseSwr(serializerOptions: DocsJsonContext.Default.Options)
        .SetFeature(new UserApi(httpClient))
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
