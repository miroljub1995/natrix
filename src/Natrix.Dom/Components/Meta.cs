using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class MetaProps : GlobalHtmlComponentProps<HTMLMetaElement>
{
    private static readonly PropDescriptor<string> s_name = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Name = s.Value
            : null,
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<string> s_httpEquiv = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.HttpEquiv = s.Value
            : null,
        static (el, s) => el.SetAttribute("http-equiv", s));

    public IReadOnlySignal<string>? HttpEquiv
    {
        get => Get(s_httpEquiv);
        init => Set(s_httpEquiv, value);
    }

    private static readonly PropDescriptor<string> s_content = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Content = s.Value
            : null,
        static (el, s) => el.SetAttribute("content", s));

    public IReadOnlySignal<string>? Content
    {
        get => Get(s_content);
        init => Set(s_content, value);
    }

    private static readonly PropDescriptor<string> s_media = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Media = s.Value
            : null,
        static (el, s) => el.SetAttribute("media", s));

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(s_media, value);
    }
}

public class MetaEvents : HtmlElementComponentEvents<HTMLMetaElement>
{
}

public class Meta() : BaseVoidDomComponent<HTMLMetaElement, MetaProps, MetaEvents>("meta")
{
}
