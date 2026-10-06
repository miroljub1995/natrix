using Natrix.StdWeb;

namespace Natrix.Composables.Dom.Browser.Tests;

public static class TestInitializer
{
    [Before(Assembly)]
    public static async Task Before()
    {
        await StdWebProxyFactory.InitializeAsync();
    }
}
