using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticAssets;
using Microsoft.Extensions.DependencyInjection;
using Natrix.Signals;

namespace Natrix.Ssr.Components;

public sealed class MainScript : IComponent
{
    private Script? _script;

    public void Mount(IRenderSlot slot)
    {
        if (_script is not null)
        {
            throw new InvalidOperationException("Component is already mounted.");
        }

        var httpContext = AppFeatures.Features.Get<HttpContext>()
            ?? throw new InvalidOperationException("HttpContext is not registered as a feature.");

        var dotnetJsPath = ResolveDotnetJsPath(httpContext);

        _script = new Script
        {
            Props = new ScriptProps { Type = "module".ToConstSignal() },
            Children = [new DomText { Text = $$"""
                import { dotnet } from '{{dotnetJsPath}}'
                const { runMain } = await dotnet.create();
                await runMain();
                """.ToConstSignal() }],
        };

        _script.Mount(slot);
    }

    public void Unmount()
    {
        _script?.Unmount();
        _script = null;
    }

    private const string DotnetJsAssetPath = "_framework/dotnet.js";

    private static string ResolveDotnetJsPath(HttpContext httpContext)
    {
        var dataSources = httpContext.RequestServices.GetRequiredService<EndpointDataSource>();

        // An asset is mapped once per representation it was built with: an identity endpoint plus
        // one per compression format, all sharing a route. Skipping everything with a selector
        // leaves exactly one endpoint per route, so neither branch below depends on the order
        // endpoints happen to be enumerated in.
        //
        // A fingerprinted asset is routed under its content hash and carries a "label" property
        // holding the name it was built from. An unfingerprinted one — which is what you get when
        // WasmFingerprintAssets is off, as it is under `dotnet watch` — has no label and is routed
        // under that name directly. Accept either, preferring the fingerprinted route when both
        // are mapped, so production keeps its immutable, cacheable URL.
        string? unfingerprinted = null;

        foreach (var endpoint in dataSources.Endpoints)
        {
            var descriptor = endpoint.Metadata.GetMetadata<StaticAssetDescriptor>();
            if (descriptor is null || descriptor.Selectors.Count > 0)
                continue;

            var label = descriptor.Properties.SingleOrDefault(p => p.Name == "label");
            if (label is not null && label.Value == DotnetJsAssetPath)
                return "/" + descriptor.Route;

            if (label is null && descriptor.Route == DotnetJsAssetPath)
                unfingerprinted = "/" + descriptor.Route;
        }

        return unfingerprinted ?? throw new InvalidOperationException(
            $"Could not find a '{DotnetJsAssetPath}' endpoint. Ensure MapStaticAssets() is called before mounting.");
    }
}
