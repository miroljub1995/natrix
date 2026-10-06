using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core.Components;
using Natrix.Docs.Client.Components.Home;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components;

public class QuickStartProps { }

public class QuickStart : BaseComponent<QuickStartProps, NoEvents, NoSlots, NoExpose>
{

    private const string HeadingAnchorClass =
        "absolute -left-6 opacity-0 group-hover:opacity-100 text-indigo-400 dark:text-indigo-500 no-underline transition-opacity";

    private const string ProseClass = "mt-4 leading-relaxed text-gray-600 dark:text-gray-400";

    private const string LinkClass =
        "font-medium text-indigo-600 dark:text-indigo-400 underline decoration-indigo-300 dark:decoration-indigo-700 underline-offset-2 hover:decoration-current";

    /// <summary>Indentation per depth of the project tree, spelled out so Tailwind sees each class.</summary>
    private static readonly string[] TreeIndentClasses = ["pl-0", "pl-5", "pl-10"];

    // Every snippet below was checked against an app freshly created from the template.
    private const string CounterPageSource = """
        using Natrix.Core.Components;
        using Natrix.Dom.Components;
        using Natrix.Signals;

        namespace MyApp.Client.Components;

        public class CounterPage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                // Setup runs once. After that, only what reads `count` updates.
                var count = new Signal<int>(0);

                return
                [
                    new Section
                    {
                        Props = new SectionProps
                        {
                            Class = "max-w-3xl mx-auto px-4 sm:px-8 py-12".ToConstSignal(),
                        },
                        Children =
                        [
                            new P
                            {
                                Props = new PProps
                                {
                                    Class = "text-6xl font-bold tabular-nums".ToConstSignal(),
                                },
                                Children = [new DomText { Text = new Computed<string>(() => $"{count.Value}") }],
                            },
                            new Button
                            {
                                Props = new ButtonProps
                                {
                                    Class = "mt-6 rounded-lg bg-indigo-600 px-5 py-2.5 font-semibold text-white hover:bg-indigo-500".ToConstSignal(),
                                },
                                Events = new ButtonEvents { OnClick = _ => count.Value++ },
                                Children = [new DomText { Text = "Click me".ToConstSignal() }],
                            },
                        ],
                    },
                ];
            }
        }
        """;

    private const string RouteSource = """
        // Add to the Items of Routes:
        new Route
        {
            Pattern = "/counter",
            Render = () => [new CounterPage { Props = new NoProps() }],
        },
        """;

    private const string NavItemSource = """
        internal static readonly NavItem[] All =
        [
            new("Home", "/"),
            new("About", "/about"),
            new("Counter", "/counter"), // new
        ];
        """;

    private record TocEntry(string Id, string Label, bool Nested = false);

    private record Prerequisite(string Title, string Body, string Command);

    private record TreeEntry(int Depth, string Name, string Description);

    private record NextStep(string Title, string Href, string Tag, string Body);

    private static readonly TocEntry[] Toc =
    [
        new("prerequisites", "Prerequisites"),
        new("create-your-app", "Create your app"),
        new("install-the-template", "Install the template", Nested: true),
        new("create-a-project", "Create a project", Nested: true),
        new("run-it", "Run it", Nested: true),
        new("add-a-page", "Add a page", Nested: true),
        new("whats-in-the-project", "What's in the project"),
        new("troubleshooting", "Troubleshooting"),
        new("next-steps", "Next steps"),
    ];

    private static readonly Prerequisite[] Prerequisites =
    [
        new(".NET SDK 9 or 10",
            "Natrix targets both. The template defaults to .NET 10.",
            "dotnet --version"),
        new("A trusted HTTPS certificate",
            "The app serves on https://localhost. Trust the ASP.NET Core development certificate once per machine.",
            "dotnet dev-certs https --trust"),
        new("wasm-tools (optional)",
            "Not needed to develop. Install it when you publish with AOT compilation (RunAOTCompilation).",
            "dotnet workload install wasm-tools"),
    ];

    private static readonly TreeEntry[] Tree =
    [
        new(0, "MyApp/", "The solution folder"),
        new(1, "MyApp/", "The server: an ASP.NET Core app"),
        new(2, "Program.cs", "Renders each request to HTML, data included"),
        new(2, "Components/AppPage.cs", "The document around your app: <head>, scripts, styles"),
        new(1, "MyApp.Client/", "The client: WebAssembly, and every page you write"),
        new(2, "Program.cs", "Hydrates the server's HTML in the browser"),
        new(2, "Components/App.cs", "The layout and the routes"),
        new(2, "Components/HomePage.cs", "One component per page; About works the same way"),
        new(2, "Components/NavItems.cs", "The header's links"),
        new(2, "Styles/app.css", "Tailwind's entry point: themes, plugins, custom CSS"),
        new(2, "Styles.cs", "Compiles that stylesheet while your code builds"),
        new(1, "Directory.Packages.props", "Natrix package versions, in one place"),
    ];

    private static readonly NextStep[] NextSteps =
    [
        new("Todo List", "/docs/examples/todo", "Signals · ForEach · If",
            "Keyed lists, conditional rendering and child components that report back through events."),
        new("Canvas", "/docs/examples/canvas", "Refs · Canvas API · Lifecycle",
            "Drive the raw Canvas API from C#, and clean up when the component unmounts."),
        new("Data Fetching", "/docs/examples/data-fetching", "SWR · Server prefetch",
            "Fetch on the server, ship the data in the page, and revalidate in the background."),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        Site.UsePageHead(
            "Quick Start",
            "Create your first Natrix app in minutes: install the template, scaffold a server-rendered "
            + "C# WebAssembly app, run it with hot reload and add a page.");

        var activeSection = new Signal<string>(Toc[0].Id);

        OnMounted(onUnmounted =>
        {
            if (OperatingSystem.IsBrowser())
            {
                TrackActiveSection(activeSection, onUnmounted);
            }
        });

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "mx-auto max-w-6xl xl:grid xl:grid-cols-[minmax(0,1fr)_13rem] xl:gap-12".ToConstSignal(),
                },
                Children =
                [
                    new Article
                    {
                        Props = new ArticleProps
                        {
                            Class = "min-w-0 max-w-3xl pb-16".ToConstSignal(),
                        },
                        Children =
                        [
                            Intro(),
                            PrerequisitesSection(),
                            StepsSection(),
                            ProjectSection(),
                            TroubleshootingSection(),
                            NextStepsSection(),
                        ],
                    },
                    OnThisPage(activeSection),
                ],
            },
        ];
    }

    private static Header Intro() => new()
    {
        Props = new HeaderProps(),
        Children =
        [
            new P
            {
                Props = new PProps
                {
                    Class = "text-sm font-semibold uppercase tracking-wider text-indigo-600 dark:text-indigo-400".ToConstSignal(),
                },
                Children = [Text("Getting started")],
            },
            new H1
            {
                Props = new H1Props
                {
                    Id = "quick-start".ToConstSignal(),
                    Class = "group relative mt-3 scroll-mt-24 text-4xl sm:text-5xl font-bold tracking-tight text-gray-900 dark:text-white".ToConstSignal(),
                },
                Children = [HeadingAnchor("quick-start"), Text("Quick Start")],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mt-5 text-lg sm:text-xl leading-relaxed text-gray-600 dark:text-gray-400 text-pretty".ToConstSignal(),
                },
                Children =
                [
                    Text("Go from an empty folder to a C# app that renders on the server, hydrates in the browser and reloads as you edit. Four commands and one new file."),
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-8".ToConstSignal(),
                },
                Children =
                [
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "mb-2 text-sm font-medium text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [Text("Already have .NET? Here is the whole thing:")],
                    },
                    Shell(
                        "dotnet new install Natrix.Templates",
                        "dotnet new natrix -o MyApp",
                        "cd MyApp",
                        "dotnet watch --project MyApp"),
                ],
            },
        ],
    };

    private static Section PrerequisitesSection() => new()
    {
        Props = new SectionProps(),
        Children =
        [
            SectionHeading("prerequisites", "Prerequisites"),
            Prose(
                Text("You need the .NET SDK, and nothing from the JavaScript world: no Node.js, no npm and no Tailwind CLI. Tailwind runs inside the C# compiler.")),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-6 overflow-hidden rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-900/50 divide-y divide-gray-200 dark:divide-gray-800".ToConstSignal(),
                },
                Children = [.. Prerequisites.Select(PrerequisiteRow)],
            },
            Prose(
                Text("Don't have the SDK yet? "),
                ExternalLink("Download .NET", "https://dotnet.microsoft.com/download"),
                Text(" for Windows, macOS or Linux.")),
        ],
    };

    private static Div PrerequisiteRow(Prerequisite prerequisite) => new()
    {
        Props = new DivProps
        {
            Class = "flex flex-col gap-3 p-5 md:flex-row md:items-center md:justify-between md:gap-6".ToConstSignal(),
        },
        Children =
        [
            new Div
            {
                Props = new DivProps { Class = "min-w-0".ToConstSignal() },
                Children =
                [
                    new H3
                    {
                        Props = new H3Props
                        {
                            Class = "font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                        },
                        Children = [Text(prerequisite.Title)],
                    },
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "mt-1 text-sm leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [Text(prerequisite.Body)],
                    },
                ],
            },
            new Code
            {
                Props = new CodeProps
                {
                    Class = "shrink-0 self-start overflow-x-auto whitespace-nowrap rounded-md bg-gray-100 dark:bg-gray-800 px-2.5 py-1.5 font-mono text-xs text-gray-800 dark:text-gray-200 md:self-center".ToConstSignal(),
                },
                Children = [Text(prerequisite.Command)],
            },
        ],
    };

    private static Section StepsSection() => new()
    {
        Props = new SectionProps(),
        Children =
        [
            SectionHeading("create-your-app", "Create your app"),
            new Ol
            {
                Props = new OlProps
                {
                    Class = "mt-8".ToConstSignal(),
                },
                Children =
                [
                    Step(1, "install-the-template", "Install the template",
                    [
                        Prose(
                            Text("Natrix ships its project template as a NuGet package. Install it once; it stays available to "),
                            InlineCode("dotnet new"),
                            Text(" from then on.")),
                        Spaced(Shell("dotnet new install Natrix.Templates")),
                        Prose(
                            Text("To get a newer template later, run "),
                            InlineCode("dotnet new update"),
                            Text(".")),
                    ]),
                    Step(2, "create-a-project", "Create a project",
                    [
                        Prose(
                            Text("This creates a "),
                            InlineCode("MyApp"),
                            Text(" folder with two projects in it: a server that renders HTML and a WebAssembly client that takes over in the browser. Pick any name; it becomes the namespace too.")),
                        Spaced(Shell("dotnet new natrix -o MyApp")),
                        Callout("Targeting .NET 9?",
                            Text("Add "),
                            InlineCode("-F net9.0"),
                            Text(" to the command. The template defaults to "),
                            InlineCode("net10.0"),
                            Text(".")),
                    ]),
                    Step(3, "run-it", "Run it",
                    [
                        Prose(
                            InlineCode("dotnet watch"),
                            Text(" builds both projects, starts the server and opens your browser. The first build restores packages and compiles the client, so give it a minute.")),
                        Spaced(Shell("cd MyApp", "dotnet watch --project MyApp")),
                        BrowserPreview(),
                        Prose(
                            Text("Click "),
                            Strong("About"),
                            Text(" in the header: the page changes without a reload. The first view came from the server as plain HTML; everything after it runs in .NET in your browser.")),
                        Callout("Prefer a plain run?",
                            InlineCode("dotnet run --project MyApp"),
                            Text(" starts the same app without watching for changes. The template also includes VS Code launch and build settings.")),
                    ]),
                    Step(4, "add-a-page", "Add a page",
                    [
                        Prose(
                            Text("A page is a component: a class whose "),
                            InlineCode("Setup"),
                            Text(" method runs once and returns the elements to show. Add a counter page to the client project.")),
                        Spaced(new CSharpCode
                        {
                            Props = new CSharpCodeProps
                            {
                                FileName = "MyApp.Client/Components/CounterPage.cs",
                                Code = CounterPageSource,
                            },
                        }),
                        Prose(
                            Text("Give it a route in "),
                            InlineCode("App.cs"),
                            Text(", next to the two that are there,")),
                        Spaced(new CSharpCode
                        {
                            Props = new CSharpCodeProps
                            {
                                FileName = "MyApp.Client/Components/App.cs",
                                Code = RouteSource,
                            },
                        }),
                        Prose(
                            Text("and a link in the header, in "),
                            InlineCode("NavItems.cs"),
                            Text(":")),
                        Spaced(new CSharpCode
                        {
                            Props = new CSharpCodeProps
                            {
                                FileName = "MyApp.Client/Components/NavItems.cs",
                                Code = NavItemSource,
                            },
                        }),
                        Prose(
                            Text("Save, and "),
                            InlineCode("dotnet watch"),
                            Text(" picks it up. Open "),
                            Strong("Counter"),
                            Text(" and click: the number updates and nothing else on the page is touched. Now change "),
                            InlineCode("\"Click me\""),
                            Text(" or a class name and save again; the change appears in the open tab without a refresh.")),
                        Callout("Where Tailwind looks for classes",
                            Text("The stylesheet is built from the class names written in plain string literals in the client project. Write each class out in full, like "),
                            InlineCode("bg-indigo-600"),
                            Text(", in a string that isn't interpolated, and keep the components that use them in "),
                            InlineCode("MyApp.Client"),
                            Text(".")),
                    ]),
                ],
            },
        ],
    };

    private static Li Step(int number, string id, string title, IComponent[] body) => new()
    {
        Props = new LiProps
        {
            Class = "relative pb-12 pl-12 last:pb-0 sm:pl-14".ToConstSignal(),
        },
        Children =
        [
            // The rail that joins this step's number to the next one.
            new Span
            {
                Props = new SpanProps
                {
                    AriaHidden = true.ToConstSignal(),
                    Class = "absolute left-4 top-10 bottom-2 w-px bg-gradient-to-b from-indigo-300 to-gray-200 dark:from-indigo-800 dark:to-gray-800 sm:left-[1.125rem]".ToConstSignal(),
                },
            },
            new Span
            {
                Props = new SpanProps
                {
                    AriaHidden = true.ToConstSignal(),
                    Class = "absolute left-0 top-0 inline-flex h-8 w-8 items-center justify-center rounded-full bg-gradient-to-br from-indigo-500 to-violet-600 font-mono text-sm font-semibold text-white shadow-md shadow-indigo-500/25 sm:h-9 sm:w-9".ToConstSignal(),
                },
                Children = [Text(number.ToString())],
            },
            new H3
            {
                Props = new H3Props
                {
                    Id = id.ToConstSignal(),
                    Class = "group relative scroll-mt-24 pt-0.5 text-xl font-semibold text-gray-900 dark:text-white sm:pt-1".ToConstSignal(),
                },
                Children = [HeadingAnchor(id), Text(title)],
            },
            .. body,
        ],
    };

    /// <summary>A browser window showing what the template's home page looks like.</summary>
    private static Div BrowserPreview() => new()
    {
        Props = new DivProps
        {
            Class = "mt-6 overflow-hidden rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-950 shadow-xl shadow-gray-900/5".ToConstSignal(),
        },
        Children =
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "flex items-center gap-2 border-b border-gray-200 dark:border-gray-800 bg-gray-50 dark:bg-gray-900 px-4 py-2.5".ToConstSignal(),
                },
                Children =
                [
                    Dot("bg-red-400/80"),
                    Dot("bg-amber-400/80"),
                    Dot("bg-emerald-400/80"),
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "ml-3 min-w-0 flex-1 truncate rounded-md bg-white dark:bg-gray-800 px-3 py-1 font-mono text-xs text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [Text("https://localhost:5100")],
                    },
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "flex items-center justify-between border-b border-gray-100 dark:border-gray-800/60 px-5 py-3".ToConstSignal(),
                },
                Children =
                [
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "text-sm font-bold text-gray-900 dark:text-white".ToConstSignal(),
                        },
                        Children = [Text("MyApp")],
                    },
                    new Span
                    {
                        Props = new SpanProps
                        {
                            Class = "flex gap-1 text-xs".ToConstSignal(),
                        },
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "rounded-md bg-indigo-50 dark:bg-indigo-950 px-2 py-1 text-indigo-600 dark:text-indigo-400".ToConstSignal(),
                                },
                                Children = [Text("Home")],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "px-2 py-1 text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children = [Text("About")],
                            },
                        ],
                    },
                ],
            },
            new Div
            {
                Props = new DivProps
                {
                    Class = "px-5 py-8 sm:px-8 sm:py-10".ToConstSignal(),
                },
                Children =
                [
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "text-2xl sm:text-3xl font-bold tracking-tight text-gray-900 dark:text-white".ToConstSignal(),
                        },
                        Children = [Text("Build with Natrix")],
                    },
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "mt-3 text-sm text-gray-600 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [Text("This project was generated with the natrix template and includes server-side rendering, hydration, routing, and Tailwind CSS.")],
                    },
                ],
            },
        ],
    };

    private static Section ProjectSection() => new()
    {
        Props = new SectionProps(),
        Children =
        [
            SectionHeading("whats-in-the-project", "What's in the project"),
            Prose(
                Text("Two projects that share one set of components. The client holds your pages; the server references it and renders those same components to HTML, so a page is written once and runs in both places.")),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-6 overflow-hidden rounded-xl border border-gray-200 dark:border-gray-800 divide-y divide-gray-100 dark:divide-gray-800/70".ToConstSignal(),
                },
                Children = [.. Tree.Select(TreeRow)],
            },
        ],
    };

    private static Div TreeRow(TreeEntry entry)
    {
        var isFolder = entry.Name.EndsWith('/');

        return new Div
        {
            Props = new DivProps
            {
                Class = "flex flex-col gap-0.5 px-4 py-2.5 sm:flex-row sm:items-baseline sm:gap-6".ToConstSignal(),
            },
            Children =
            [
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = (TreeIndentClasses[entry.Depth] + " shrink-0 font-mono text-sm sm:w-72").ToConstSignal(),
                    },
                    Children =
                    [
                        new Span
                        {
                            Props = new SpanProps
                            {
                                Class = (isFolder
                                    ? "font-semibold text-indigo-600 dark:text-indigo-400"
                                    : "text-gray-900 dark:text-gray-100").ToConstSignal(),
                            },
                            Children = [Text(entry.Name)],
                        },
                    ],
                },
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = (TreeIndentClasses[entry.Depth] + " text-sm text-gray-600 dark:text-gray-400 sm:pl-0").ToConstSignal(),
                    },
                    Children = [Text(entry.Description)],
                },
            ],
        };
    }

    private static Section TroubleshootingSection() => new()
    {
        Props = new SectionProps(),
        Children =
        [
            SectionHeading("troubleshooting", "Troubleshooting"),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-6 space-y-3".ToConstSignal(),
                },
                Children =
                [
                    Question("dotnet new can't find a template called natrix",
                        Text("The template isn't installed for the SDK you're running. Run "),
                        InlineCode("dotnet new install Natrix.Templates"),
                        Text(" again, then check with "),
                        InlineCode("dotnet new list natrix"),
                        Text(".")),
                    Question("The browser says the connection isn't private",
                        Text("The development certificate isn't trusted yet. Run "),
                        InlineCode("dotnet dev-certs https --trust"),
                        Text(", then restart the app and the browser.")),
                    Question("Port 5100 is already in use",
                        Text("Change "),
                        InlineCode("applicationUrl"),
                        Text(" in "),
                        InlineCode("MyApp/Properties/launchSettings.json"),
                        Text(" to a free port.")),
                    Question("A Tailwind class has no effect",
                        Text("Tailwind only generates the classes it finds in plain string literals in the client project. Classes in an interpolated string, like "),
                        InlineCode("$\"px-4 {extra}\""),
                        Text(", classes put together at runtime, and classes named only in the server project are never seen. Write them out in full in a plain string in "),
                        InlineCode("MyApp.Client"),
                        Text(".")),
                    Question("Moving an existing app to a newer Natrix",
                        Text("Change the versions in "),
                        InlineCode("Directory.Packages.props"),
                        Text(". The three Natrix packages are released together, so keep them on the same version.")),
                ],
            },
        ],
    };

    private static Details Question(string question, params IComponent[] answer) => new()
    {
        Props = new DetailsProps
        {
            Class = "group rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-900/50 open:border-indigo-200 dark:open:border-indigo-900".ToConstSignal(),
        },
        Children =
        [
            new Summary
            {
                Props = new SummaryProps
                {
                    Class = "flex cursor-pointer list-none items-center justify-between gap-4 px-5 py-4 font-medium text-gray-900 dark:text-white [&::-webkit-details-marker]:hidden".ToConstSignal(),
                },
                Children =
                [
                    new Span { Props = new SpanProps(), Children = [Text(question)] },
                    new Span
                    {
                        Props = new SpanProps
                        {
                            AriaHidden = true.ToConstSignal(),
                            Class = "shrink-0 text-xl leading-none text-gray-400 transition-transform group-open:rotate-45".ToConstSignal(),
                        },
                        Children = [Text("+")],
                    },
                ],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "px-5 pb-5 leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                },
                Children = answer,
            },
        ],
    };

    private static Section NextStepsSection() => new()
    {
        Props = new SectionProps(),
        Children =
        [
            SectionHeading("next-steps", "Next steps"),
            Prose(
                Text("Each example runs live on this site, with its source a click away. Read them in any order.")),
            new Div
            {
                Props = new DivProps
                {
                    Class = "mt-6 grid gap-4 sm:grid-cols-2".ToConstSignal(),
                },
                Children =
                [
                    .. NextSteps.Select(NextStepCard),
                    new A
                    {
                        Props = new AProps
                        {
                            Href = Site.GitHubUrl.ToConstSignal(),
                            Class = "group flex flex-col rounded-xl border border-gray-200 dark:border-gray-800 bg-gray-950 p-5 text-white transition hover:-translate-y-0.5 hover:border-indigo-500 hover:shadow-lg hover:shadow-indigo-500/10".ToConstSignal(),
                        },
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "font-mono text-xs text-gray-400".ToConstSignal(),
                                },
                                Children = [Text("Issues · Discussions · Source")],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "mt-2 font-semibold".ToConstSignal(),
                                },
                                Children = [Text("Natrix on GitHub")],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "mt-1 flex-1 text-sm leading-relaxed text-gray-400".ToConstSignal(),
                                },
                                Children = [Text("Natrix is young and moving fast. Questions, bug reports and what you build all help shape it.")],
                            },
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "mt-3 text-sm font-semibold text-indigo-300".ToConstSignal(),
                                },
                                Children = [Text("Open the repository  ↗")],
                            },
                        ],
                    },
                ],
            },
        ],
    };

    private static RouterLink NextStepCard(NextStep step) => new()
    {
        Props = new RouterLinkProps
        {
            Href = step.Href,
            Class = "group flex flex-col rounded-xl border border-gray-200 dark:border-gray-800 bg-white dark:bg-gray-900/50 p-5 transition hover:-translate-y-0.5 hover:border-indigo-300 dark:hover:border-indigo-700 hover:shadow-lg hover:shadow-indigo-500/5",
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
                    Children = [Text(step.Tag)],
                },
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = "mt-2 font-semibold text-gray-900 dark:text-white group-hover:text-indigo-600 dark:group-hover:text-indigo-400 transition-colors".ToConstSignal(),
                    },
                    Children = [Text(step.Title)],
                },
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = "mt-1 flex-1 text-sm leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                    },
                    Children = [Text(step.Body)],
                },
                new Span
                {
                    Props = new SpanProps
                    {
                        Class = "mt-3 text-sm font-semibold text-indigo-600 dark:text-indigo-400".ToConstSignal(),
                    },
                    Children = [Text("Try it  →")],
                },
            ],
        },
    };

    /// <summary>
    /// Keeps the section being read highlighted in the page outline: the last one whose heading
    /// has scrolled up past the sticky header, or the last section once the page bottoms out.
    /// </summary>
    /// <remarks>
    /// Measured on every scroll event - which browsers already deliver at most once a frame -
    /// rather than with an IntersectionObserver, which misses headings that a fast scroll carries
    /// across its band between two callbacks.
    /// </remarks>
    [SupportedOSPlatform("browser")]
    private static void TrackActiveSection(Signal<string> activeSection, Action<Action> onUnmounted)
    {
        const double ReadingLine = 120;

        var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);
        var headings = Toc
            .Select(entry => window.Document.GetElementById(entry.Id))
            .OfType<Element>()
            .ToArray();

        if (headings.Length == 0)
        {
            return;
        }

        void Update()
        {
            var root = window.Document.DocumentElement;
            var atBottom = root is not null && window.InnerHeight + window.ScrollY >= root.ScrollHeight - 2;

            var active = headings[0].Id;
            foreach (var heading in headings)
            {
                if (!atBottom && heading.GetBoundingClientRect().Top > ReadingLine)
                {
                    break;
                }

                active = heading.Id;
            }

            activeSection.Value = active;
        }

        var onScroll = new EventListener(new EventListenerCallbackManaged(_ => Update()));

        window.AddEventListener("scroll", onScroll);
        Update();

        onUnmounted(() => window.RemoveEventListener("scroll", onScroll));
    }

    private static Aside OnThisPage(IReadOnlySignal<string> activeSection) => new()
    {
        Props = new AsideProps
        {
            Class = "hidden xl:block".ToConstSignal(),
        },
        Children =
        [
            new Nav
            {
                Props = new NavProps
                {
                    AriaLabel = "On this page".ToConstSignal(),
                    Class = "sticky top-24".ToConstSignal(),
                },
                Children =
                [
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "text-xs font-semibold uppercase tracking-wide text-gray-400 dark:text-gray-500".ToConstSignal(),
                        },
                        Children = [Text("On this page")],
                    },
                    new Ul
                    {
                        Props = new UlProps
                        {
                            Class = "mt-3 space-y-2 border-l border-gray-200 dark:border-gray-800 text-sm".ToConstSignal(),
                        },
                        Children =
                        [
                            .. Toc.Select(entry => new Li
                            {
                                Props = new LiProps(),
                                Children =
                                [
                                    new A
                                    {
                                        Props = new AProps
                                        {
                                            Href = $"#{entry.Id}".ToConstSignal(),
                                            Class = new Computed<string>(() => (entry.Nested, activeSection.Value == entry.Id) switch
                                            {
                                                (false, true) => "-ml-px block border-l border-indigo-500 pl-4 font-medium text-indigo-600 dark:text-indigo-400 transition-colors",
                                                (true, true) => "-ml-px block border-l border-indigo-500 pl-7 font-medium text-indigo-600 dark:text-indigo-400 transition-colors",
                                                (false, false) => "-ml-px block border-l border-transparent pl-4 text-gray-600 dark:text-gray-400 hover:border-gray-400 hover:text-gray-900 dark:hover:text-white transition-colors",
                                                (true, false) => "-ml-px block border-l border-transparent pl-7 text-gray-500 hover:border-gray-400 hover:text-gray-900 dark:hover:text-white transition-colors",
                                            }),
                                        },
                                        Children = [Text(entry.Label)],
                                    },
                                ],
                            }),
                        ],
                    },
                ],
            },
        ],
    };

    private static H2 SectionHeading(string id, string text) => new()
    {
        Props = new H2Props
        {
            Id = id.ToConstSignal(),
            Class = "group relative mt-16 scroll-mt-24 border-t border-gray-200 dark:border-gray-800 pt-10 text-2xl sm:text-3xl font-bold tracking-tight text-gray-900 dark:text-white".ToConstSignal(),
        },
        Children = [HeadingAnchor(id), Text(text)],
    };

    private static A HeadingAnchor(string id) => new()
    {
        Props = new AProps
        {
            Href = $"#{id}".ToConstSignal(),
            AriaHidden = true.ToConstSignal(),
            Class = HeadingAnchorClass.ToConstSignal(),
        },
        Children = [Text("#")],
    };

    private static Div Callout(string title, params IComponent[] body) => new()
    {
        Props = new DivProps
        {
            Class = "mt-6 rounded-xl border border-indigo-200 dark:border-indigo-900 bg-indigo-50/60 dark:bg-indigo-950/30 px-5 py-4".ToConstSignal(),
        },
        Children =
        [
            new P
            {
                Props = new PProps
                {
                    Class = "text-sm font-semibold text-indigo-900 dark:text-indigo-200".ToConstSignal(),
                },
                Children = [Text(title)],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mt-1 text-sm leading-relaxed text-gray-700 dark:text-gray-300".ToConstSignal(),
                },
                Children = body,
            },
        ],
    };

    private static Terminal Shell(params string[] lines) => new()
    {
        Props = new TerminalProps { Lines = lines },
    };

    private static Div Spaced(IComponent child) => new()
    {
        Props = new DivProps { Class = "mt-4".ToConstSignal() },
        Children = [child],
    };

    private static Span Dot(string color) => new()
    {
        Props = new SpanProps
        {
            Class = ("h-3 w-3 shrink-0 rounded-full " + color).ToConstSignal(),
        },
    };

    // Rich text is built from alternating text and elements; two DomTexts side by side would be
    // merged by the HTML parser and no longer match what the client hydrates against.
    private static P Prose(params IComponent[] children) => new()
    {
        Props = new PProps { Class = ProseClass.ToConstSignal() },
        Children = children,
    };

    private static Code InlineCode(string code) => new()
    {
        Props = new CodeProps
        {
            Class = "rounded bg-gray-100 dark:bg-gray-800 px-1.5 py-0.5 font-mono text-[0.85em] text-gray-900 dark:text-gray-100".ToConstSignal(),
        },
        Children = [Text(code)],
    };

    private static Strong Strong(string text) => new()
    {
        Props = new StrongProps { Class = "font-semibold text-gray-900 dark:text-white".ToConstSignal() },
        Children = [Text(text)],
    };

    private static A ExternalLink(string text, string href) => new()
    {
        Props = new AProps
        {
            Href = href.ToConstSignal(),
            Class = LinkClass.ToConstSignal(),
        },
        Children = [Text(text)],
    };

    private static DomText Text(string text) => new() { Text = text.ToConstSignal() };
}
