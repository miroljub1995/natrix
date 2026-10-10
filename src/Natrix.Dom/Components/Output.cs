using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public class OutputProps : GlobalHtmlComponentProps<HTMLOutputElement>
{
    private static PropDescriptor<string>? s_htmlFor;

    public IReadOnlySignal<string>? HtmlFor
    {
        get => Get(s_htmlFor);
        init => Set(ref s_htmlFor, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.HtmlFor.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("for", s)));
    }

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

    private static PropDescriptor<string>? s_defaultValue;

    public IReadOnlySignal<string>? DefaultValue
    {
        get => Get(s_defaultValue);
        init => Set(ref s_defaultValue, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.DefaultValue = s.Value;
            },
            // Written as the content on the server; see GetChildren.
            static (_, _) => { }));
    }

    private static PropDescriptor<string>? s_value;

    public IReadOnlySignal<string>? Value
    {
        get => Get(s_value);
        init => Set(ref s_value, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Value = s.Value;
            },
            // Written as the content on the server; see GetChildren.
            static (_, _) => { }));
    }
}

public class OutputEvents : HtmlElementComponentEvents<HTMLOutputElement>
{
}

public class Output() : BaseNonVoidDomComponent<HTMLOutputElement, OutputProps, OutputEvents>("output")
{
    /// <summary>
    /// A output's value is its text content, so the server writes the first of <c>Value</c>,
    /// <c>DefaultValue</c> and the children, as React does.
    /// </summary>
    protected override IComponent[]? GetChildren(bool isSsr)
    {
        if (!isSsr)
        {
            return base.GetChildren(isSsr);
        }

        var text = Props?.Value ?? Props?.DefaultValue;
        return text is null ? base.GetChildren(isSsr) : [new DomText { Text = text }];
    }
}
