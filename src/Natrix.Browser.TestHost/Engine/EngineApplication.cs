using Microsoft.Testing.Platform.Builder;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// The test framework side. Equivalent to the entry point Microsoft.Testing.Platform
/// would have generated, plus the sink that lets the bridge observe results.
/// </summary>
internal static class EngineApplication
{
    public static async Task<int> RunAsync(string[] args, Action<ITestApplicationBuilder, string[]> registerExtensions)
    {
        var builder = await TestApplication.CreateBuilderAsync(args);

        registerExtensions(builder, args);
        builder.TestHost.AddDataConsumer(_ => new TestEventSink());

        using var app = await builder.BuildAsync();
        return await app.RunAsync();
    }
}
