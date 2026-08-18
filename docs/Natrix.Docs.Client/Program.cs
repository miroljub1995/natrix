using System.Runtime.InteropServices.JavaScript;
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

// Same-origin, so the endpoint is addressed exactly as the markup addresses it.
var userApi = new UserApi(new HttpClient { BaseAddress = new Uri($"{window.Location.Origin}/") });

var _ = new NatrixHostBuilder()
    .UseRootElement(appElement)
    .UseTeleport()
    .UseLifecycleHooks()
    // The serializer context lets the values the server prefetched arrive with the page instead
    // of being fetched again, and keeps that transfer AOT-safe.
    .UseSwr(serializerOptions: DocsJsonContext.Default.Options)
    .SetFeature(userApi)
    .SetFeature<IClientHydrationStateFeature>(hydration)
    .SetFeature<INavigationFeature>(new ClientNavigationFeature(window))
    .UseRootComponent(() => new HydrationRoot { Children = [new DocsApp { Props = new DocsAppProps() }] })
    .UseDefaultHotReloadManager()
    .UseTailwindCssHotReload(Styles.GetCss)
    .Build()
    .Mount();

await Task.Delay(Timeout.Infinite);
