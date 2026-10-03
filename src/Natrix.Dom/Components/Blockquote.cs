using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class BlockquoteProps : GlobalHtmlComponentProps<HTMLQuoteElement>
{
    private static readonly PropDescriptor<string> s_cite = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Cite = s.Value
            : null,
        static (el, s) => el.SetAttribute("cite", s));

    public IReadOnlySignal<string>? Cite
    {
        get => Get(s_cite);
        init => Set(s_cite, value);
    }
}

public class BlockquoteEvents : HtmlElementComponentEvents<HTMLQuoteElement>
{
}

public class Blockquote() : BaseNonVoidDomComponent<HTMLQuoteElement, BlockquoteProps, BlockquoteEvents>("blockquote")
{
}
