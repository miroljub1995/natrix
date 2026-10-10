using Natrix.Core.Components;

namespace Natrix.Core.Features.Routing;

/// <summary>
/// Defines a single route mapping: a URL pattern and the components to render
/// when that pattern matches the current path. This is a data class —
/// <see cref="Routes"/> handles matching and mount/unmount via <see cref="If"/> components.
/// </summary>
public sealed class Route
{
    private RouteTemplateMatcher? _matcher;

    /// <summary>
    /// The route template pattern (e.g. <c>/users/{id}</c>).
    /// Follows ASP.NET Core route template syntax.
    /// </summary>
    public required string Pattern { get; init; }

    /// <summary>
    /// Factory that produces the components to render when this route matches.
    /// </summary>
    public required Func<IComponent[]> Render { get; init; }

    /// <summary>
    /// Optional child routes for nested routing.
    /// The parent route's <see cref="Render"/> should include an <see cref="Outlet"/>
    /// component where child content will be rendered.
    /// </summary>
    public Route[]? Children { get; init; }

    /// <summary>
    /// The path a redirect route sends the browser to, or <c>null</c> for a route that renders.
    /// Set through <see cref="Redirect"/>.
    /// </summary>
    public string? RedirectTo { get; private init; }

    /// <summary>
    /// Creates a route that renders nothing of its own: when it matches, <see cref="Routes"/>
    /// renders whatever <paramref name="to"/> matches instead and replaces the current history
    /// entry with it, so Back does not return to a URL that only bounces forward again.
    /// On the server the replace is recorded as a redirect for the host to answer.
    /// </summary>
    /// <param name="pattern">The route template pattern, as for any other route.</param>
    /// <param name="to">The absolute path to send the browser to (e.g. <c>/docs/quick-start</c>).</param>
    public static Route Redirect(string pattern, string to)
    {
        if (!to.StartsWith('/'))
        {
            throw new ArgumentException($"Redirect target '{to}' must be an absolute path.", nameof(to));
        }

        return new Route
        {
            Pattern = pattern,
            Render = static () => [],
            RedirectTo = to,
        };
    }

    /// <summary>
    /// The pre-parsed matcher for this route's <see cref="Pattern"/>.
    /// Lazily initialized on first access.
    /// </summary>
    internal RouteTemplateMatcher Matcher => _matcher ??= RouteTemplateMatcher.Parse(Pattern);
}
