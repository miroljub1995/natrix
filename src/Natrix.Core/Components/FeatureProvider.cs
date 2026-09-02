using Natrix.Core.Features;
using Natrix.Core.RenderRoot;

namespace Natrix.Core.Components;

/// <summary>
/// Publishes features to everything mounted beneath it. The subtree sees them through
/// <see cref="AppFeatures.Current"/> during its own <c>Setup</c>; nothing above does.
/// </summary>
/// <remarks>
/// <para>
/// This is the answer to a feature that cannot be built at registration because it is built
/// <em>from</em> other features. <see cref="NatrixHostBuilder.SetFeature{TFeature}"/> runs while
/// the application is still being described, in an order nothing guarantees, so a feature
/// resolving another one there is reading a collection that may still be filling up.
/// <see cref="Configure"/> runs at mount, once, with everything registered.
/// </para>
/// <para>
/// It renders into the slot it is given and adds nothing to it, so a provider is invisible to the
/// markup and to hydration — the child occupies exactly the position the provider was handed.
/// </para>
/// </remarks>
public sealed class FeatureProvider : IComponent
{
    /// <summary>
    /// Populates the subtree's own feature layer. Writes land on that layer, while reads fall
    /// through to the host's — so a provider can resolve what it needs and publish what it built
    /// through the same collection, and neither its writes nor its overrides are visible above it.
    /// </summary>
    public required Action<IFeatureCollection> Configure { get; init; }

    /// <summary>
    /// What to mount underneath. Called after <see cref="Configure"/>, and while the features it
    /// registered are the ambient ones, so a child built here already sees them.
    /// </summary>
    public required Func<IComponent> Child { get; init; }

    private IComponent? _child;

    public void Mount(IRenderSlot slot)
    {
        var parentFeatures = AppFeatures.Current
            ?? throw new InvalidOperationException(
                $"{nameof(AppFeatures)}.{nameof(AppFeatures.Current)} must be set before mounting a "
                + $"{nameof(FeatureProvider)}.");

        // Configured before the ambient swap, so that a provider that throws leaves the collection
        // it was handed exactly as it found it.
        var childFeatures = new FeatureCollection(parentFeatures);
        Configure(childFeatures);

        AppFeatures.Current = childFeatures;
        try
        {
            _child = Child();
            _child.Mount(slot);
        }
        finally
        {
            AppFeatures.Current = parentFeatures;
        }
    }

    public void Unmount()
    {
        _child?.Unmount();
        _child = null;
    }
}
