using Natrix.Core.Components;

namespace Natrix.Dom.TestCases;

/// <summary>
/// One rendering expectation for a DOM component, shared by the server and the browser suites so
/// both check the same component against the same markup.
/// </summary>
/// <remarks>
/// <see cref="Html"/> is what the server writes with attributes sorted. The browser suite serialises
/// the rendered nodes the same way (attributes sorted, empty values bare) and compares them to
/// <see cref="BrowserHtml"/> when set, or to <see cref="Html"/> otherwise.
/// </remarks>
public sealed class DomCase(string name, Func<IComponent> create, string html)
{
    public string Name => name;

    public Func<IComponent> Create => create;

    public string Html => html;

    /// <summary>
    /// The browser's markup, when it differs from <see cref="Html"/>: props the client applies through
    /// a JS property that does not reflect to an attribute.
    /// </summary>
    public string? BrowserHtml { get; init; }

    /// <summary>
    /// A JS property the browser suite reads on the rendered element, and the value it must hold.
    /// For props whose effect is not visible in the markup.
    /// </summary>
    public (string Name, object Value)? Property { get; init; }

    /// <summary>
    /// Why the server does not yet render the expected markup. The server suite skips the case
    /// with this reason, so the expectation stays the correct one rather than the current output.
    /// </summary>
    public string? ServerIssue { get; init; }

    /// <summary>
    /// Why the browser does not yet render the expected markup; the browser suite skips the case.
    /// </summary>
    public string? BrowserIssue { get; init; }

    public override string ToString() => name;
}
