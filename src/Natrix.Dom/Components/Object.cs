using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ObjectProps : GlobalHtmlComponentProps<HTMLObjectElement>
{
    private static readonly object s_dataKey = new();

    public new IReadOnlySignal<string>? Data
    {
        get => Get<IReadOnlySignal<string>>(s_dataKey);
        init => Set(
            s_dataKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Data = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("data", (IReadOnlySignal<string>)s));
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

    private static readonly object s_widthKey = new();

    public IReadOnlySignal<string>? Width
    {
        get => Get<IReadOnlySignal<string>>(s_widthKey);
        init => Set(
            s_widthKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Width = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("width", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_heightKey = new();

    public IReadOnlySignal<string>? Height
    {
        get => Get<IReadOnlySignal<string>>(s_heightKey);
        init => Set(
            s_heightKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Height = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("height", (IReadOnlySignal<string>)s));
    }
}

public class ObjectEvents : HtmlElementComponentEvents<HTMLObjectElement>
{
}

public class Object() : BaseNonVoidDomComponent<HTMLObjectElement, ObjectProps, ObjectEvents>("object")
{
}
