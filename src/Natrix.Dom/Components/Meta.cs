using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class MetaProps : GlobalHtmlComponentProps<HTMLMetaElement>
{
    private static readonly object s_nameKey = new();

    public IReadOnlySignal<string>? Name
    {
        get => Get<IReadOnlySignal<string>>(s_nameKey);
        init => Set(
            s_nameKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Name = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("name", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_httpEquivKey = new();

    public IReadOnlySignal<string>? HttpEquiv
    {
        get => Get<IReadOnlySignal<string>>(s_httpEquivKey);
        init => Set(
            s_httpEquivKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.HttpEquiv = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("http-equiv", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_contentKey = new();

    public IReadOnlySignal<string>? Content
    {
        get => Get<IReadOnlySignal<string>>(s_contentKey);
        init => Set(
            s_contentKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Content = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("content", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_mediaKey = new();

    public IReadOnlySignal<string>? Media
    {
        get => Get<IReadOnlySignal<string>>(s_mediaKey);
        init => Set(
            s_mediaKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Media = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("media", (IReadOnlySignal<string>)s));
    }
}

public class MetaEvents : HtmlElementComponentEvents<HTMLMetaElement>
{
}

public class Meta() : BaseVoidDomComponent<HTMLMetaElement, MetaProps, MetaEvents>("meta")
{
}
