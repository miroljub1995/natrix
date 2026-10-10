using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Core.RenderRoot;
using Natrix.Signals;

namespace Natrix.Core.Features.Routing;

/// <summary>
/// Routing component that builds a tree of <see cref="If"/> components — one per
/// <see cref="Route"/> at every nesting level. Each <see cref="If"/> condition is a
/// <see cref="Computed{T}"/> that tracks which route matches at that level. Because
/// <see cref="If"/> handles mount/unmount, routes that still match on navigation are
/// never re-mounted; only the first level that changes swaps its branch.
/// </summary>
public class Routes : IComponent
{
    public required Route[] Items { get; init; }

    /// <summary>
    /// How many redirect routes one navigation may pass through before matching gives up, so a
    /// redirect loop fails loudly instead of hanging the page.
    /// </summary>
    private const int MaxRedirects = 8;

    private readonly EffectScope _effectScope = new();
    private ComposedComponent? _composed;

    public void Mount(IRenderSlot slot)
    {
        var parentFeatures = AppFeatures.Current
            ?? throw new InvalidOperationException(
                "AppFeatures.Current must be set before mounting Routes.");

        var navigation = parentFeatures.Get<INavigationFeature>()
            ?? throw new InvalidOperationException(
                "INavigationFeature must be registered before mounting Routes. " +
                "Call builder.SetFeature<INavigationFeature>(...) during host setup.");

        var routes = Items;

        // Single reactive computation that walks the entire route tree and
        // follows redirect routes to the page they point at. Because the
        // redirect is resolved here, the target renders straight away: the
        // tree never mounts, and so never flashes, an intermediate branch.
        var resolution = new Computed<RouteResolution>(
            () => Resolve(routes, navigation.CurrentPath.Value));

        // A linked chain of RouteMatch, or null if no complete match exists.
        var matchedRoute = new Computed<RouteMatch?>(() => resolution.Value.Match);

        _effectScope.Run(() =>
        {
            // The URL still names the redirect route's path; replace it, so the
            // address bar, links that highlight the current page, and the server's
            // redirect response all agree with what is rendered. A replace rather
            // than a push keeps Back from returning to a URL that bounces forward.
            new Effect(_ =>
            {
                var redirectPath = resolution.Value.RedirectPath;

                using var untracked = new UntrackedScope();

                if (redirectPath is not null)
                {
                    navigation.ReplaceAsync(redirectPath);
                }
            });
        });

        var ifComponents = BuildRouteBranches(routes, matchedRoute);
        _composed = new ComposedComponent(ifComponents);
        _composed.Mount(slot);
    }

    public void Unmount()
    {
        _composed?.Unmount();
        _composed = null;
        _effectScope.Dispose();
    }

    /// <summary>
    /// Builds one <see cref="If"/> component per route at this nesting level.
    /// Each <see cref="If"/>'s condition checks whether <paramref name="matchedRoute"/>
    /// selected this route.
    /// </summary>
    internal static IComponent[] BuildRouteBranches(
        Route[] routes,
        Computed<RouteMatch?> matchedRoute)
    {
        var components = new IComponent[routes.Length];
        for (int i = 0; i < routes.Length; i++)
        {
            var route = routes[i];
            var condition = new Computed<bool>(() => matchedRoute.Value?.Route == route);

            components[i] = new If
            {
                Condition = condition,
                Then = () =>
                [
                    new RouteScope
                    {
                        Route = route,
                        MatchedRoute = matchedRoute,
                    }
                ]
            };
        }

        return components;
    }

    /// <summary>
    /// Matches <paramref name="path"/>, following redirect routes until a route that renders
    /// matches, or none does.
    /// </summary>
    private static RouteResolution Resolve(Route[] routes, string path)
    {
        string? redirectPath = null;

        for (var redirects = 0; ; redirects++)
        {
            var match = MatchRouteTree(routes, ParsePathSegments(path));
            var leaf = match;
            while (leaf?.ChildMatch is not null)
            {
                leaf = leaf.ChildMatch;
            }

            if (leaf?.Route.RedirectTo is not { } target)
            {
                return new RouteResolution(match, redirectPath);
            }

            if (redirects == MaxRedirects)
            {
                throw new InvalidOperationException(
                    $"Redirect routes sent '{path}' through more than {MaxRedirects} redirects; check them for a loop.");
            }

            path = target;
            redirectPath = target;
        }
    }

    /// <summary>
    /// Recursively walks the route tree and returns a linked chain of
    /// <see cref="RouteMatch"/> — or <c>null</c> if no route can fully
    /// resolve <paramref name="remainingSegments"/>.
    /// </summary>
    private static RouteMatch? MatchRouteTree(
        Route[] routes, ReadOnlyMemory<string> remainingSegments)
    {
        var span = remainingSegments.Span;

        for (int i = 0; i < routes.Length; i++)
        {
            var route = routes[i];

            if (!route.Matcher.TryMatchPrefix(span, out var values))
            {
                continue;
            }

            if (route.Children is null)
            {
                // Leaf route: all segments must be consumed
                // (or a catch-all handles the rest).
                if (!route.Matcher.HasCatchAll && route.Matcher.SegmentCount < remainingSegments.Length)
                {
                    continue;
                }

                return new RouteMatch(route, values, null);
            }

            var childRoutes = route.Children;
            var childMatch = MatchRouteTree(
                childRoutes,
                remainingSegments[route.Matcher.SegmentCount..]
            );

            if (childMatch is not null)
            {
                return new RouteMatch(route, values, childMatch);
            }
        }

        return null;
    }

    private static string[] ParsePathSegments(string path) =>
        path.Trim('/').Split('/', StringSplitOptions.RemoveEmptyEntries);

    /// <summary>
    /// What a path resolves to: the match to render, and the path a redirect route sent it to,
    /// or <c>null</c> when it matched without one.
    /// </summary>
    private sealed record RouteResolution(RouteMatch? Match, string? RedirectPath);
}
