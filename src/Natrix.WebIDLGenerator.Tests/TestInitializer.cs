using Natrix.JSCore;

namespace Natrix.WebIDLGenerator.Tests;

public static class TestInitializer
{
    [Before(Assembly)]
    public static async Task Before()
    {
        await WebIDLGeneratorTestsProxyFactory.InitializeAsync();
    }
}