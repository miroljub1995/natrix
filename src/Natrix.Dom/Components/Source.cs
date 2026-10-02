using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class SourceProps : GlobalHtmlComponentProps<HTMLSourceElement>
{
    private static readonly object s_srcKey = new();

    public IReadOnlySignal<string>? Src
    {
        get => Get<IReadOnlySignal<string>>(s_srcKey);
        init => Set(
            s_srcKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Src = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("src", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_typeKey = new();

    public IReadOnlySignal<string>? Type
    {
        get => Get<IReadOnlySignal<string>>(s_typeKey);
        init => Set(
            s_typeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Type = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("type", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_srcsetKey = new();

    public IReadOnlySignal<string>? Srcset
    {
        get => Get<IReadOnlySignal<string>>(s_srcsetKey);
        init => Set(
            s_srcsetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Srcset = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("srcset", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_sizesKey = new();

    public IReadOnlySignal<string>? Sizes
    {
        get => Get<IReadOnlySignal<string>>(s_sizesKey);
        init => Set(
            s_sizesKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Sizes = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("sizes", (IReadOnlySignal<string>)s));
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

    private static readonly object s_widthKey = new();

    public IReadOnlySignal<uint>? Width
    {
        get => Get<IReadOnlySignal<uint>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("width", (IReadOnlySignal<uint>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<uint>? Height
    {
        get => Get<IReadOnlySignal<uint>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<uint>)s).Value
                : null,
            static (el, s) => el.SetUInt("height", (IReadOnlySignal<uint>)s));
    }
}

public class SourceEvents : HtmlElementComponentEvents<HTMLSourceElement>
{
}

public class Source() : BaseVoidDomComponent<HTMLSourceElement, SourceProps, SourceEvents>("source")
{
}
