using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Core;

public sealed class NatrixHostBuilder
{
    private Func<IComponent>? _rootComponentFactory;
    private IRenderRoot? _renderRoot;
    private readonly FeatureCollection _features = new();

    /// <summary>
    /// Application-wide features visible to every component in the tree.
    /// </summary>
    public IFeatureCollection Features => _features;

    /// <summary>
    /// Convenience for <c>Features.Set&lt;TFeature&gt;(instance)</c>.
    /// </summary>
    public NatrixHostBuilder SetFeature<TFeature>(TFeature instance)
    {
        _features.Set(instance);
        return this;
    }

    public NatrixHostBuilder UseRootComponent(Func<IComponent> factory)
    {
        _rootComponentFactory = factory;
        return this;
    }

    public NatrixHostBuilder UseRootRenderer(IRenderRoot renderRoot)
    {
        _renderRoot = renderRoot;
        return this;
    }

    public NatrixHost Build()
    {
        if (_rootComponentFactory is null)
            throw new InvalidOperationException("Root component must be configured via UseRootComponent.");
        if (_renderRoot is null)
            throw new InvalidOperationException("Root renderer must be configured via UseRootElement or UseRootRenderer.");

        return new NatrixHost(_rootComponentFactory, _renderRoot, _features);
    }
}
