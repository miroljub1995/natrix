using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class MetaProps : GlobalHtmlComponentProps<HTMLMetaElement>
{
    private static PropDescriptor<string>? s_name;

    public IReadOnlySignal<string>? Name
    {
        get => Get(s_name);
        init => Set(ref s_name, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Name = s.Value;
            },
            static (el, s) => el.SetAttribute("name", s)));
    }

    private static PropDescriptor<string>? s_httpEquiv;

    public IReadOnlySignal<string>? HttpEquiv
    {
        get => Get(s_httpEquiv);
        init => Set(ref s_httpEquiv, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.HttpEquiv = s.Value;
            },
            static (el, s) => el.SetAttribute("http-equiv", s)));
    }

    private static PropDescriptor<string>? s_content;

    public IReadOnlySignal<string>? Content
    {
        get => Get(s_content);
        init => Set(ref s_content, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Content = s.Value;
            },
            static (el, s) => el.SetAttribute("content", s)));
    }

    private static PropDescriptor<string>? s_media;

    public IReadOnlySignal<string>? Media
    {
        get => Get(s_media);
        init => Set(ref s_media, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Media = s.Value;
            },
            static (el, s) => el.SetAttribute("media", s)));
    }
}

public class MetaEvents : HtmlElementComponentEvents<HTMLMetaElement>
{
}

public class Meta() : BaseVoidDomComponent<HTMLMetaElement, MetaProps, MetaEvents>("meta")
{
}
