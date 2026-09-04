using Microsoft.Testing.Platform.Builder;

namespace Natrix.Browser.TestHost.Engine;

/// <summary>
/// The TUnit side. Equivalent to the entry point Microsoft.Testing.Platform would
/// have generated, plus the extensions that let the bridge observe and steer it.
/// </summary>
internal static class EngineApplication
{
    public static async Task<int> RunAsync(string[] args)
    {
        var builder = await TestApplication.CreateBuilderAsync(args);

        TUnit.Engine.Framework.TestingPlatformBuilderHook.AddExtensions(builder, args);

        builder.TestHost.AddDataConsumer(_ => new TestEventSink());

        using var app = await builder.BuildAsync();
        return await app.RunAsync();
    }
}
