using Natrix.JSCore;
using Natrix.StdWeb;

namespace Natrix.Browser.Tests;

public static class DomHelpers
{
    public static Element CreateContainer()
    {
        var window = JSObjectProxyFactory.GetProxy<Window>(
            System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis);

        return window.Document.CreateElement("div");
    }
}
