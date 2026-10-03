using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class ObjectProps : GlobalHtmlComponentProps<HTMLObjectElement>
{
    private static readonly PropDescriptor<string> s_data = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Data = s.Value
            : null,
        static (el, s) => el.SetAttribute("data", s));

    public new IReadOnlySignal<string>? Data
    {
        get => Get(s_data);
        init => Set(s_data, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Type = s.Value
            : null,
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
    }

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

    private static readonly PropDescriptor<string> s_width = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Width = s.Value
            : null,
        static (el, s) => el.SetAttribute("width", s));

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<string> s_height = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Height = s.Value
            : null,
        static (el, s) => el.SetAttribute("height", s));

    public IReadOnlySignal<string>? Height
    {
        get => Get(s_height);
        init => Set(s_height, value);
    }
}

public class ObjectEvents : HtmlElementComponentEvents<HTMLObjectElement>
{
}

public class Object() : BaseNonVoidDomComponent<HTMLObjectElement, ObjectProps, ObjectEvents>("object")
{
}
