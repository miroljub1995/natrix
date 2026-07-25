using System.Text.Json.Nodes;
using Natrix.Ssr.Abstractions.Features.HydrationState;

namespace Natrix.Ssr.Features.HydrationState;

/// <summary>
/// Server-side <see cref="IServerHydrationStateFeature"/> implementation.
/// Create one instance per request and register it on the <see cref="NatrixHostBuilder"/>
/// before mounting. Components call <see cref="RegisterDehydrateCallback"/> during their setup phase
/// to contribute state; the server-side hydration script component calls <see cref="Dehydrate"/>
/// to serialize the result into the SSR output.
/// </summary>
public sealed class ServerHydrationStateFeature : IServerHydrationStateFeature
{
    private Action<JsonObject>? _callbacks;

    public JsonObject Dehydrate()
    {
        var obj = new JsonObject { ["hydrate"] = true };
        _callbacks?.Invoke(obj);
        return obj;
    }

    public void RegisterDehydrateCallback(Action<JsonObject> callback) => _callbacks += callback;

    public void DeregisterDehydrateCallback(Action<JsonObject> callback) => _callbacks -= callback;
}
