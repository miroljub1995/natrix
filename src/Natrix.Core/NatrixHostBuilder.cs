using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Core;

public sealed class NatrixHostBuilder
{
    private Func<IComponent>? _rootComponentFactory;
    private IRenderRoot? _renderRoot;
    private readonly FeatureCollection _features = new();
    private readonly List<Func<Func<IComponent>, IComponent>> _middleware = [];

    /// <summary>
    /// Application-wide features visible to every component in the tree.
    /// </summary>
    public IFeatureCollection Features => _features;

    /// <summary>
    /// Convenience for <c>Features.Set&lt;TFeature&gt;(instance)</c>.
    /// </summary>
    /// <remarks>
    /// For a feature that stands on its own. One built out of other features belongs in
    /// <see cref="Use(Action{IFeatureCollection})"/> instead: this runs while the application is
    /// still being described, so what it resolves depends on how far down the chain the call sits.
    /// </remarks>
    public NatrixHostBuilder SetFeature<TFeature>(TFeature instance)
    {
        _features.Set(instance);
        return this;
    }

    /// <summary>
    /// Wraps the application in a component of your own, which is handed the rest of the tree as
    /// <c>next</c> and decides where — or whether — to mount it.
    ///
    /// Middleware runs outermost first, in the order it was added, so one added after another sits
    /// inside it and sees what it published.
    /// </summary>
    /// <remarks>
    /// The counterpart to <see cref="SetFeature{TFeature}"/>, and the one to reach for whenever a
    /// feature is built out of other features: registration happens while the application is still
    /// being described, in an order nothing guarantees, whereas this runs at mount with everything
    /// registered. <see cref="Use(Action{IFeatureCollection})"/> is the short form for the common
    /// case of publishing features and mounting the rest unchanged.
    /// </remarks>
    public NatrixHostBuilder Use(Func<Func<IComponent>, IComponent> middleware)
    {
        ArgumentNullException.ThrowIfNull(middleware);

        _middleware.Add(middleware);
        return this;
    }

    /// <summary>
    /// Publishes features to the whole application, resolved at mount rather than at registration.
    /// </summary>
    /// <param name="configure">
    /// Receives a feature layer of its own: writes stay in the application's subtree, and reads
    /// fall through to whatever <see cref="SetFeature{TFeature}"/> registered — including from
    /// middleware added before this one.
    /// </param>
    /// <inheritdoc cref="Use(Func{Func{IComponent}, IComponent})" path="/remarks"/>
    public NatrixHostBuilder Use(Action<IFeatureCollection> configure)
    {
        ArgumentNullException.ThrowIfNull(configure);

        return Use(next => new FeatureProvider { Configure = configure, Child = next });
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

    /// <summary>
    /// Enables component lifecycle hooks and defers mounted hooks until the mount pass has
    /// finished building the tree.
    /// </summary>
    /// <remarks>
    /// Registering <see cref="ILifecycleHooksFeature"/> is what gives an app lifecycle hooks at
    /// all: where the feature is absent, mounted hooks are dropped instead of run. Hosts that
    /// mount into a live tree opt in by calling this; server rendering deliberately does not.
    /// </remarks>
    public NatrixHostBuilder UseLifecycleHooks()
    {
        return SetFeature<ILifecycleHooksFeature>(new LifecycleHooksFeature());
    }

    public NatrixHost Build()
    {
        if (_rootComponentFactory is null)
            throw new InvalidOperationException("Root component must be configured via UseRootComponent.");
        if (_renderRoot is null)
            throw new InvalidOperationException("Root renderer must be configured via UseRootElement or UseRootRenderer.");

        // Folded from the inside out, so that the first middleware added ends up outermost and
        // the root component stays at the bottom of the chain.
        var factory = _rootComponentFactory;
        for (var i = _middleware.Count - 1; i >= 0; i--)
        {
            var middleware = _middleware[i];
            var next = factory;
            factory = () => middleware(next);
        }

        return new NatrixHost(factory, _renderRoot, _features);
    }
}
