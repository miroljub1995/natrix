using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using Natrix.Browser;
using Natrix.Browser.Components;
using Natrix.Browser.Features.Routing;
using Natrix.Core;
using Natrix.Browser.Features.HydrationState;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core.Features.Routing;
using Natrix.Core.HotReload;
using Natrix.Docs.Client;
using Natrix.Docs.Client.Components;
using Natrix.Docs.Client.Components.Examples.DataFetching;
using Natrix.Docs.Contracts;
using Natrix.JSCore;
using Natrix.StdWeb;
using Natrix.Swr;
using Natrix.TailwindCss;

if (!OperatingSystem.IsBrowser())
{
    throw new PlatformNotSupportedException();
}

await StdWebProxyFactory.InitializeAsync();

var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
var appElement = window.Document.GetElementById("app")
    ?? throw new System.Exception("Element with id 'app' not found.");

var hydration = new ClientHydrationStateFeature();

// The same context the server configured its endpoints with, and nothing else in the chain: under
// AOT there is no reflection fallback to fall back to.
//
// Web defaults, because that is what ConfigureHttpJsonOptions starts from on the server. The
// resolver chain settles which types can be read; the conventions around it - camelCase, and
// case-insensitive matching - settle whether the bytes are understood, and a client reading the
// server's JSON under different conventions silently deserializes every property to null.
var serializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    TypeInfoResolverChain = { DocsJsonContext.Default },
};

// Same-origin, so the endpoint is addressed exactly as the markup addresses it.
var userApi = new UserApi(
    new HttpClient { BaseAddress = new Uri($"{window.Location.Origin}/") },
    serializerOptions);

var _ = new NatrixHostBuilder()
    .UseRootElement(appElement)
    .UseTeleport()
    .UseLifecycleHooks()
    .SetFeature(serializerOptions)
    // Picks up the options registered above, so the values the server prefetched arrive with the
    // page instead of being fetched again.
    .UseSwr()
    .SetFeature(userApi)
    .SetFeature<IClientHydrationStateFeature>(hydration)
    .SetFeature<INavigationFeature>(new ClientNavigationFeature(window))
    .UseRootComponent(() => new HydrationRoot { Children = [new DocsApp { Props = new DocsAppProps() }] })
    .UseDefaultHotReloadManager()
    .UseTailwindCssHotReload(Styles.GetCss)
    .Build()
    .Mount();

await Task.Delay(Timeout.Infinite);
