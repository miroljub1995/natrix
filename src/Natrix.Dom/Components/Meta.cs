using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class MetaProps : GlobalHtmlComponentProps<HTMLMetaElement>
{
    private static readonly PropDescriptor<string> s_name = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Name = s.Value;
        },
        static (el, s) => el.SetAttribute("name", s));

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(s_name, value);
    }

    private static readonly PropDescriptor<string> s_httpEquiv = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.HttpEquiv = s.Value;
        },
        static (el, s) => el.SetAttribute("http-equiv", s));

    public IReadOnlySignal<string>? HttpEquiv
    {
        get => Get(s_httpEquiv);
        init => Set(s_httpEquiv, value);
    }

    private static readonly PropDescriptor<string> s_content = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Content = s.Value;
        },
        static (el, s) => el.SetAttribute("content", s));

    public IReadOnlySignal<string>? Content
    {
        get => Get(s_content);
        init => Set(s_content, value);
    }

    private static readonly PropDescriptor<string> s_media = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Media = s.Value;
        },
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
