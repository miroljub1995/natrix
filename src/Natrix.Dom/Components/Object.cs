using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class ObjectProps : GlobalHtmlComponentProps<HTMLObjectElement>
{
    private static readonly PropDescriptor<string> s_data = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Data = s.Value;
        },
        static (el, s) => el.SetAttribute("data", s));

    public new IReadOnlySignal<string>? Data
    {
        get => Get(s_data);
        init => Set(s_data, value);
    }

    private static readonly PropDescriptor<string> s_type = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Type = s.Value;
        },
        static (el, s) => el.SetAttribute("type", s));

    public IReadOnlySignal<string>? Type
    {
        get => Get(s_type);
        init => Set(s_type, value);
    }

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

    private static readonly PropDescriptor<string> s_width = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Width = s.Value;
        },
        static (el, s) => el.SetAttribute("width", s));

    public IReadOnlySignal<string>? Width
    {
        get => Get(s_width);
        init => Set(s_width, value);
    }

    private static readonly PropDescriptor<string> s_height = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Height = s.Value;
        },
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
