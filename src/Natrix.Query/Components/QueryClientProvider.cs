using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Query.Features;
using Natrix.Signals;

namespace Natrix.Query.Components;

/// <summary>Input for <see cref="QueryClientProvider"/>.</summary>
public sealed class QueryClientProviderProps
{
    /// <summary>The client the subtree below this component uses.</summary>
    public required QueryClient Client { get; init; }

    /// <summary>The subtree.</summary>
    public IComponent[] Children { get; init; } = [];
}

/// <summary>
/// Scopes a <see cref="QueryClient"/> to part of the tree, the way Vue Query's
/// <c>QueryClientProvider</c> does. Descendants resolve this client instead of the one the
/// host registered, which is what lets an isolated widget — or a test — run against its own
/// cache.
/// </summary>
/// <remarks>
/// The client is mounted while this component is, so focus and reconnect refetching follow the
/// subtree's lifetime.
/// </remarks>
public sealed class QueryClientProvider : BaseComponent<QueryClientProviderProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        // Written into this component's own feature layer, so it is visible to descendants
        // without leaking to siblings.
        AppFeatures.Features.Set<IQueryClientFeature>(new QueryClientFeature(Props.Client));

        Props.Client.Mount();
        new Effect(onCleanup => onCleanup(Props.Client.Unmount));

        return Props.Children;
    }
}
