using System.Runtime.InteropServices.JavaScript;
using Natrix.Browser;
using Natrix.Browser.Components;
using Natrix.Browser.Features.Routing;
using Natrix.Core;
using Natrix.Browser.Features.HydrationState;
using Natrix.Browser.Abstractions.Features.HydrationState;
using Natrix.Core.Features.Routing;
using Natrix.Core.HotReload;
using MyNatrixApp.Client;
using MyNatrixApp.Client.Components;
using Natrix.JSCore;
using Natrix.StdWeb;
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

var _ = new NatrixHostBuilder()
    .UseRootElement(appElement)
    .UseTeleport()
    .UseLifecycleHooks()
    .SetFeature<IClientHydrationStateFeature>(hydration)
    .SetFeature<INavigationFeature>(new ClientNavigationFeature(window))
    .UseRootComponent(() => new HydrationRoot { Children = [new App { Props = new AppProps() }] })
    .UseDefaultHotReloadManager()
    .UseTailwindCssHotReload(Styles.GetCss)
    .Build()
    .Mount();

await Task.Delay(Timeout.Infinite);
