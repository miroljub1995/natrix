using System.Runtime.InteropServices.JavaScript;
using Natrix.Core.Components;
using Natrix.Docs.Client.Components.Home;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class HomePageProps { }

public class HomePage : BaseComponent<HomePageProps, NoEvents, NoSlots, NoExpose>
{
    private const string GitHubUrl = "https://github.com/miroljub1995/natrix";
    private const string InstallCommand = "dotnet new install Natrix.Templates";

    private const string SectionHeadingClass =
        "text-3xl sm:text-4xl font-bold tracking-tight text-gray-900 dark:text-white";

    private const string SectionLeadClass =
        "mt-4 max-w-2xl text-lg text-gray-600 dark:text-gray-400";

    private const string EyebrowClass =
        "text-sm font-semibold uppercase tracking-wider text-indigo-600 dark:text-indigo-400";

    private record Feature(string Icon, string Title, string Body);

    private record Step(string Title, string Body);

    private record Example(string Title, string Href, string Tag, string Body);

    private static readonly Feature[] Features =
    [
        new(WwwRoot.Assets_Icons_Signals_Svg, "Fine-grained signals",
            "Signal, Computed and Effect track their own dependencies. A change updates the one text node or attribute that reads it. Components never re-render, and there is no virtual DOM to diff."),
        new(WwwRoot.Assets_Icons_Ssr_Svg, "Server-rendered, then hydrated",
            "Every page arrives as complete HTML, so it paints fast and search engines can read it. The WebAssembly client then adopts the existing DOM instead of rebuilding it."),
        new(WwwRoot.Assets_Icons_Web_Apis_Svg, "The whole Web platform, typed",
            "C# bindings generated from the WebIDL specs: DOM, Fetch, Canvas, WebGL and more. IntelliSense for the browser, with no hand-written interop."),
        new(WwwRoot.Assets_Icons_Tailwind_Svg, "Tailwind, inside the compiler",
            "The real Tailwind compiler runs during your build and emits only the classes your C# uses. No Node, no CLI and no watcher in your app."),
        new(WwwRoot.Assets_Icons_Swr_Svg, "Data fetching that feels instant",
            "Stale-while-revalidate, ported from React SWR. Prefetch on the server, ship the cache inside the page, and revalidate in the background."),
        new(WwwRoot.Assets_Icons_Aot_Svg, "Ready for AOT, built for iteration",
            "Trim- and AOT-safe throughout, down to source-generated JSON. Hot reload covers both your components and your styles while you work."),
    ];

    private static readonly Step[] Steps =
    [
        new("The server renders",
            "ASP.NET Core runs your components and sends real HTML, with the data they need already fetched."),
        new("The browser paints",
            "Content is visible, and indexable, before a single byte of .NET has been downloaded."),
        new("WebAssembly hydrates",
            "The same components attach to the DOM that is already there. Signals take over, and nothing re-renders."),
    ];

    private static readonly Example[] Examples =
    [
        new("Todo List", "/examples/todo", "Signals · ForEach · If",
            "State, keyed list rendering, conditional rendering and child components reporting back through generated events."),
        new("Canvas", "/examples/canvas", "Refs · Canvas API · Lifecycle",
            "Bouncing balls on the raw Canvas API, driven by requestAnimationFrame and cleaned up when the component unmounts."),
        new("Data Fetching", "/examples/data-fetching", "SWR · Server prefetch",
            "Stale-while-revalidate over a real endpoint: prefetched on the server, with loading, retry and error states."),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "relative isolate mx-auto max-w-6xl".ToConstSignal(),
                },
                Children =
                [
                    Hero(),
                    LiveDemo(),
                    FeatureGrid(),
                    HowItWorks(),
                    ExampleGrid(),
                    GetStarted(),
                ],
            },
        ];
    }

    private static Section Hero() => new()
    {
        Props = new SectionProps
        {
            Class = "relative pt-8 pb-16 sm:pt-16 sm:pb-24 text-center".ToConstSignal(),
        },
        Children =
        [
            // Soft glow behind the headline.
            new Div
            {
                Props = new DivProps
                {
                    AriaHidden = true.ToConstSignal(),
                    Class = "pointer-events-none absolute inset-x-0 -top-8 -z-10 h-[28rem] bg-[radial-gradient(ellipse_at_top,rgba(99,102,241,0.22),rgba(16,185,129,0.08)_40%,transparent_70%)]".ToConstSignal(),
                },
            },
            new P
            {
                Props = new PProps
                {
                    Class = "inline-flex items-center gap-2 rounded-full border border-gray-200 dark:border-gray-800 bg-white/70 dark:bg-gray-900/70 px-4 py-1.5 text-sm text-gray-600 dark:text-gray-300 backdrop-blur".ToConstSignal(),
                },
                Children =
                [
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "h-2 w-2 rounded-full bg-emerald-500".ToConstSignal(),
                        },
                    },
                    Text("Open source · MIT · .NET 9 & 10"),
                ],
            },
            new H1
            {
                Props = new H1Props
                {
                    Id = "home".ToConstSignal(),
                    Class = "mt-8 text-5xl sm:text-6xl lg:text-7xl font-extrabold tracking-tight text-gray-900 dark:text-white text-balance".ToConstSignal(),
                },
                Children =
                [
                    Text("Reactive web UIs, "),
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "bg-gradient-to-r from-indigo-500 via-violet-500 to-emerald-500 bg-clip-text text-transparent".ToConstSignal(),
                        },
                        Children = [Text("written in C#.")],
                    },
                ],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mx-auto mt-6 max-w-2xl text-lg sm:text-xl leading-relaxed text-gray-600 dark:text-gray-400 text-pretty".ToConstSignal(),
                },
                Children =
                [
                    Text("Natrix runs your C# in the browser on WebAssembly. Pages render on the server first, then fine-grained signals update exactly the DOM nodes that changed. No virtual DOM, no Razor, no JavaScript to write."),
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-10 flex flex-col sm:flex-row items-center justify-center gap-3".ToConstSignal(),
                },
                Children =
                [
                    new RouterLink
                    {
                        Props = new RouterLinkProps
                        {
                            Href = "/quick-start",
                            Class = "inline-flex w-full sm:w-auto items-center justify-center gap-2 rounded-lg bg-indigo-600 px-6 py-3 font-semibold text-white shadow-lg shadow-indigo-600/25 hover:bg-indigo-500 transition-colors",
                        },
                        Slots = new RouterLinkSlots { Default = () => [Text("Get started  →")] },
                    },
                    new RouterLink
                    {
                        Props = new RouterLinkProps
                        {
                            Href = "/examples/todo",
                            Class = "inline-flex w-full sm:w-auto items-center justify-center rounded-lg border border-gray-300 dark:border-gray-700 bg-white dark:bg-gray-900 px-6 py-3 font-semibold text-gray-900 dark:text-white hover:border-indigo-400 dark:hover:border-indigo-500 transition-colors",
                        },
                        Slots = new RouterLinkSlots { Default = () => [Text("See the examples")] },
                    },
                    new A
                    {
                        Props = new AProps
                        {
                            Href = GitHubUrl.ToConstSignal(),
                            Class = "inline-flex w-full sm:w-auto items-center justify-center gap-2 rounded-lg px-6 py-3 font-semibold text-gray-700 dark:text-gray-300 hover:text-gray-900 dark:hover:text-white transition-colors".ToConstSignal(),
                        },
                        Children =
                        [
                            new Img
                            {
                                Props = new ImgProps
                                {
                                    Src = WwwRoot.Assets_Github_Mark_Svg.ToConstSignal(),
                                    Alt = "".ToConstSignal(),
                                    Class = "h-5 w-5 dark:invert".ToConstSignal(),
                                },
                            },
                            Text("Star on GitHub"),
                        ],
                    },
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-8 flex justify-center".ToConstSignal(),
                },
                Children = [CopyCommand(InstallCommand)],
            },
        ],
    };

    private static Section LiveDemo() => new()
    {
        Props = new SectionProps
        {
            Class = "pb-20 sm:pb-28".ToConstSignal(),
        },
        Children =
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "grid gap-6 lg:grid-cols-5 items-stretch".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "min-w-0 lg:col-span-3".ToConstSignal(),
                        },
                        Children =
                        [
                            new CSharpCode
                            {
                                Props = new CSharpCodeProps
                                {
                                    FileName = "Counter.cs",
                                    Code = LiveCounter.Source,
                                },
                            },
                        ],
                    },
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "flex flex-col overflow-hidden rounded-xl border border-gray-200 dark:border-gray-800 bg-gradient-to-b from-gray-50 to-white dark:from-gray-900 dark:to-gray-950 lg:col-span-2".ToConstSignal(),
                        },
                        Children =
                        [
                            new Div
                            {
                                Props = new DivProps
                                {
                                    Class = "flex items-center gap-2 border-b border-gray-200 dark:border-gray-800 px-4 py-3 text-xs font-medium text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children =
                                [
                                    new Span
                                    {
                                        Props = new SpanProps
                                        {
                                            Class = "relative flex h-2 w-2".ToConstSignal(),
                                        },
                                        Children =
                                        [
                                            new Span
                                            {
                                                Props = new SpanProps
                                                {
                                                    Class = "absolute inline-flex h-full w-full animate-ping rounded-full bg-emerald-400 opacity-75".ToConstSignal(),
                                                },
                                            },
                                            new Span
                                            {
                                                Props = new SpanProps
                                                {
                                                    Class = "relative inline-flex h-2 w-2 rounded-full bg-emerald-500".ToConstSignal(),
                                                },
                                            },
                                        ],
                                    },
                                    Text("Live. This is .NET, running in your browser."),
                                ],
                            },
                            new Div
                            {
                                Props = new DivProps
                                {
                                    Class = "flex-1".ToConstSignal(),
                                },
                                Children = [new LiveCounter { Props = new NoProps() }],
                            },
                            new P
                            {
                                Props = new PProps
                                {
                                    Class = "border-t border-gray-200 dark:border-gray-800 px-4 py-3 text-xs leading-relaxed text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children =
                                [
                                    Text("Counter.cs is the whole component, minus the styling. Its first render came from the server; each click now updates two text nodes and nothing else."),
                                ],
                            },
                        ],
                    },
                ],
            },
        ],
    };

    private static Section FeatureGrid() => new()
    {
        Props = new SectionProps
        {
            Class = "pb-20 sm:pb-28".ToConstSignal(),
        },
        Children =
        [
            SectionIntro("why-natrix", "Why Natrix", "Everything a modern UI framework gives you, in the language you already ship.",
                "One language from the database to the DOM, with the type checker watching all of it. Natrix brings fine-grained reactivity in the spirit of SolidJS and Vue, and SWR-style data fetching, to .NET."),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-12 grid gap-6 sm:grid-cols-2 lg:grid-cols-3".ToConstSignal(),
                },
                Children = [.. Features.Select(FeatureCard)],
            },
        ],
    };

    private static Div FeatureCard(Feature feature) => new()
    {
        Props = new DivProps
        {
            Class = "group rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-900/50 p-6 transition hover:-translate-y-0.5 hover:border-indigo-300 dark:hover:border-indigo-700 hover:shadow-lg hover:shadow-indigo-500/5".ToConstSignal(),
        },
        Children =
        [
            new Span
            {
                Props = new SpanProps
                {
                    Class = "inline-flex h-10 w-10 items-center justify-center rounded-lg bg-gradient-to-br from-indigo-500 to-violet-600 shadow-md shadow-indigo-500/20".ToConstSignal(),
                },
                Children =
                [
                    new Img
                    {
                        Props = new ImgProps
                        {
                            Src = feature.Icon.ToConstSignal(),
                            Alt = "".ToConstSignal(),
                            Class = "h-5 w-5".ToConstSignal(),
                        },
                    },
                ],
            },
            new H3
            {
                Props = new H3Props
                {
                    Class = "mt-5 text-lg font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                },
                Children = [Text(feature.Title)],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mt-2 leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                },
                Children = [Text(feature.Body)],
            },
        ],
    };

    private static Section HowItWorks() => new()
    {
        Props = new SectionProps
        {
            Class = "pb-20 sm:pb-28".ToConstSignal(),
        },
        Children =
        [
            SectionIntro("how-it-works", "How it works", "Fast on the first paint. Alive on the first click.",
                "One component tree, rendered twice: once on the server for the HTML, once in the browser to make it interactive."),
            new Ol
            {
                Props = new OlProps
                {
                    Class = "mt-12 grid gap-6 md:grid-cols-3".ToConstSignal(),
                },
                Children = [.. Steps.Select((step, index) => StepCard(step, index + 1))],
            },
        ],
    };

    private static Li StepCard(Step step, int number) => new()
    {
        Props = new LiProps
        {
            Class = "relative rounded-xl border border-gray-200 dark:border-gray-800 p-6".ToConstSignal(),
        },
        Children =
        [
            new Span
            {
                Props = new SpanProps
                {
                    Class = "font-mono text-sm font-semibold text-indigo-600 dark:text-indigo-400".ToConstSignal(),
                },
                Children = [Text($"0{number}")],
            },
            new H3
            {
                Props = new H3Props
                {
                    Class = "mt-3 text-lg font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                },
                Children = [Text(step.Title)],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mt-2 leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                },
                Children = [Text(step.Body)],
            },
        ],
    };

    private static Section ExampleGrid() => new()
    {
        Props = new SectionProps
        {
            Class = "pb-20 sm:pb-28".ToConstSignal(),
        },
        Children =
        [
            SectionIntro("examples", "Examples", "Don't take our word for it. Click around.",
                "Every example runs live on this site, next to a link to its source."),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-12 grid gap-6 md:grid-cols-3".ToConstSignal(),
                },
                Children = [.. Examples.Select(ExampleCard)],
            },
        ],
    };

    private static RouterLink ExampleCard(Example example) => new()
    {
        Props = new RouterLinkProps
        {
            Href = example.Href,
            Class = "group flex flex-col rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-900/50 p-6 transition hover:-translate-y-0.5 hover:border-indigo-300 dark:hover:border-indigo-700 hover:shadow-lg hover:shadow-indigo-500/5",
        },
        Slots = new RouterLinkSlots
        {
            Default = () =>
            [
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = "font-mono text-xs text-gray-500 dark:text-gray-400".ToConstSignal(),
                    },
                    Children = [Text(example.Tag)],
                },
                new H3
                {
                    Props = new H3Props
                    {
                        Class = "mt-3 text-lg font-semibold text-gray-900 dark:text-white group-hover:text-indigo-600 dark:group-hover:text-indigo-400 transition-colors".ToConstSignal(),
                    },
                    Children = [Text(example.Title)],
                },
                new P
                {
                    Props = new PProps
                    {
                        Class = "mt-2 flex-1 leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                    },
                    Children = [Text(example.Body)],
                },
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = "mt-4 text-sm font-semibold text-indigo-600 dark:text-indigo-400".ToConstSignal(),
                    },
                    Children = [Text("Try it  →")],
                },
            ],
        },
    };

    private static Section GetStarted() => new()
    {
        Props = new SectionProps
        {
            Class = "pb-16".ToConstSignal(),
        },
        Children =
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "relative overflow-hidden rounded-2xl bg-gray-950 px-6 py-12 sm:px-12 sm:py-16 ring-1 ring-white/10".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            AriaHidden = true.ToConstSignal(),
                            Class = "pointer-events-none absolute inset-0 bg-[radial-gradient(circle_at_top_right,rgba(99,102,241,0.35),transparent_55%),radial-gradient(circle_at_bottom_left,rgba(16,185,129,0.18),transparent_50%)]".ToConstSignal(),
                        },
                    },
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "relative grid gap-10 lg:grid-cols-2 lg:items-center".ToConstSignal(),
                        },
                        Children =
                        [
                            new Div
                            {
                                Props = new DivProps(),
                                Children =
                                [
                                    new H2
                                    {
                                        Props = new H2Props
                                        {
                                            Id = "get-started".ToConstSignal(),
                                            Class = "text-3xl sm:text-4xl font-bold tracking-tight text-white".ToConstSignal(),
                                        },
                                        Children = [Text("Your first Natrix app is three commands away.")],
                                    },
                                    new P
                                    {
                                        Props = new PProps
                                        {
                                            Class = "mt-4 text-lg leading-relaxed text-gray-300".ToConstSignal(),
                                        },
                                        Children =
                                        [
                                            Text("The template gives you a server-rendered host, a WebAssembly client, routing and Tailwind, wired up and ready to change. Natrix is young and moving fast, so expect APIs to evolve, and tell us what you build."),
                                        ],
                                    },
                                    new Div
                                    {
                                        Props = new DivProps
                                        {
                                            Class = "mt-8 flex flex-col sm:flex-row gap-3".ToConstSignal(),
                                        },
                                        Children =
                                        [
                                            new RouterLink
                                            {
                                                Props = new RouterLinkProps
                                                {
                                                    Href = "/quick-start",
                                                    Class = "inline-flex items-center justify-center rounded-lg bg-white px-6 py-3 font-semibold text-gray-950 hover:bg-gray-200 transition-colors",
                                                },
                                                Slots = new RouterLinkSlots { Default = () => [Text("Read the Quick Start  →")] },
                                            },
                                            new A
                                            {
                                                Props = new AProps
                                                {
                                                    Href = GitHubUrl.ToConstSignal(),
                                                    Class = "inline-flex items-center justify-center rounded-lg border border-white/20 px-6 py-3 font-semibold text-white hover:bg-white/10 transition-colors".ToConstSignal(),
                                                },
                                                Children = [Text("Browse the source")],
                                            },
                                        ],
                                    },
                                ],
                            },
                            new Pre
                            {
                                Props = new PreProps
                                {
                                    Class = "overflow-x-auto rounded-xl border border-white/10 bg-black/40 p-5 font-mono text-sm leading-loose".ToConstSignal(),
                                },
                                Children =
                                [
                                    new Code
                                    {
                                        Props = new CodeProps(),
                                        Children =
                                        [
                                            TerminalLine("# once", null),
                                            TerminalLine(null, InstallCommand),
                                            TerminalLine("# then, for every app", null),
                                            TerminalLine(null, "dotnet new natrix -n MyApp"),
                                            TerminalLine(null, "dotnet run --project MyApp/MyApp.csproj"),
                                        ],
                                    },
                                ],
                            },
                        ],
                    },
                ],
            },
        ],
    };

    private static Span TerminalLine(string? comment, string? command) => new()
    {
        Props = new SpanProps
        {
            Class = "block whitespace-pre".ToConstSignal(),
        },
        Children = comment is not null
            ? [new Span { Props = new SpanProps { Class = "text-gray-500".ToConstSignal() }, Children = [Text(comment)] }]
            :
            [
                new Span { Props = new SpanProps { Class = "select-none text-emerald-400".ToConstSignal() }, Children = [Text("$ ")] },
                new Span { Props = new SpanProps { Class = "text-gray-100".ToConstSignal() }, Children = [Text(command!)] },
            ],
    };

    private static Div SectionIntro(string id, string eyebrow, string heading, string lead) => new()
    {
        Props = new DivProps
        {
            Class = "max-w-3xl".ToConstSignal(),
        },
        Children =
        [
            new P
            {
                Props = new PProps { Class = EyebrowClass.ToConstSignal() },
                Children = [Text(eyebrow)],
            },
            new H2
            {
                Props = new H2Props
                {
                    Id = id.ToConstSignal(),
                    Class = $"mt-3 {SectionHeadingClass}".ToConstSignal(),
                },
                Children = [Text(heading)],
            },
            new P
            {
                Props = new PProps { Class = SectionLeadClass.ToConstSignal() },
                Children = [Text(lead)],
            },
        ],
    };

    private static Div CopyCommand(string command)
    {
        var copied = new Signal<bool>(false);

        return new Div
        {
            Props = new DivProps
            {
                Class = "inline-flex max-w-full items-center gap-3 rounded-lg border border-gray-200 dark:border-gray-800 bg-gray-50 dark:bg-gray-900 py-2 pl-4 pr-2 font-mono text-sm".ToConstSignal(),
            },
            Children =
            [
                new Span
                {
                    Props = new SpanProps { Class = "select-none text-emerald-600 dark:text-emerald-400".ToConstSignal() },
                    Children = [Text("$")],
                },
                new Code
                {
                    Props = new CodeProps { Class = "min-w-0 overflow-x-auto whitespace-nowrap text-gray-800 dark:text-gray-200".ToConstSignal() },
                    Children = [Text(command)],
                },
                new Button
                {
                    Props = new ButtonProps
                    {
                        Title = "Copy command".ToConstSignal(),
                        Class = "shrink-0 rounded-md px-2.5 py-1 font-sans text-xs font-medium text-gray-500 dark:text-gray-400 hover:bg-gray-200 dark:hover:bg-gray-800 hover:text-gray-900 dark:hover:text-white transition-colors".ToConstSignal(),
                    },
                    Events = new ButtonEvents
                    {
                        OnClick = (_) =>
                        {
                            if (!OperatingSystem.IsBrowser())
                            {
                                return;
                            }

                            var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
                            window.Navigator.Clipboard.WriteText(command);
                            copied.Value = true;
                        },
                    },
                    Children = [new DomText { Text = new Computed<string>(() => copied.Value ? "Copied" : "Copy") }],
                },
            ],
        };
    }

    private static DomText Text(string text) => new() { Text = text.ToConstSignal() };
}
