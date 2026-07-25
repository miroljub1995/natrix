using System.Runtime.InteropServices.JavaScript;
using Natrix.Core.RenderRoot;
using Natrix.CoreExample.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;
using Exception = System.Exception;

// new App()
//     .WithRootAnchor(new DomAnchor())
//     .WithRootComponent(x => new HelloWorld(x).Setup(new()))
//     .Start();

if (!OperatingSystem.IsBrowser())
{
    throw new PlatformNotSupportedException();
}

await StdWebProxyFactory.InitializeAsync();

var root = new DomRenderRoot(JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document.GetElementById("app") ??
                             throw new Exception("App element not found."));

new ParentComponent
{
    Props = new ParentComponentProps(),
}.Mount(root.CreateFirstSlot());

await Task.Delay(Timeout.Infinite);