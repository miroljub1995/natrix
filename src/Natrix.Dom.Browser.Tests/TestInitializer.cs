using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

public static class TestInitializer
{
    [Before(Assembly)]
    public static async Task Before()
    {
        await StdWebProxyFactory.InitializeAsync();
    }
}
