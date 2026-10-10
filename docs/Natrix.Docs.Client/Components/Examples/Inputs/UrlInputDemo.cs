using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using static Natrix.Docs.Client.Components.Examples.Inputs.InputUi;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class UrlInputDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    /// <summary>What the inputs page shows beside the demo. Keep it in step with the logic below.</summary>
    public const string Source = """
        public class UrlField : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var url = new Signal<string>("https://github.com/miroljub1995/natrix?tab=readme");

                // System.Uri does the parsing: the same .NET on the server and in the browser.
                var parts = new Computed<string>(() =>
                    Uri.TryCreate(url.Value, UriKind.Absolute, out var uri)
                        ? $"{uri.Scheme} · {uri.Host} · {uri.AbsolutePath} · {uri.Query}"
                        : "Not an absolute URL");

                return
                [
                    new Input
                    {
                        Props = new InputProps
                        {
                            Type = "url".ToConstSignal(),
                            Value = url,
                        },
                        Events = new InputEvents { OnInput = url.ToDomEvent() },
                    },
                    new P
                    {
                        Props = new PProps(),
                        Children = [new DomText { Text = parts }],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var url = new Signal<string>("https://github.com/miroljub1995/natrix?tab=readme");
        var parts = new Computed<string>(() =>
            Uri.TryCreate(url.Value, UriKind.Absolute, out var uri)
                ? $"{uri.Scheme} · {uri.Host} · {uri.AbsolutePath} · {uri.Query}"
                : "Not an absolute URL");

        return
        [
            Stack(
                Field("Website", "inputs-url-field", new Input
                {
                    Props = new InputProps
                    {
                        Id = "inputs-url-field".ToConstSignal(),
                        Type = "url".ToConstSignal(),
                        Value = url,
                        Class = FieldClass.ToConstSignal(),
                    },
                    Events = new InputEvents { OnInput = url.ToDomEvent() },
                }),
                Result(parts)),
        ];
    }
}
