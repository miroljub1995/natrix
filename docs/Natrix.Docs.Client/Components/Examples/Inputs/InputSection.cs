using Natrix.Core.Components;
using Natrix.Docs.Client.Components.Home;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.Inputs;

public class InputSectionProps
{
    public required string Id { get; init; }
    public required string Title { get; init; }

    /// <summary>The markup the section is about, shown beside the title, like <c>type="text"</c>.</summary>
    public required string Tag { get; init; }

    public required string Description { get; init; }
    public required string FileName { get; init; }
    public required string Code { get; init; }
}

public class InputSectionSlots
{
    public required Func<IComponent[]> Demo { get; init; }
}

/// <summary>
/// One input on the inputs page: a heading to link to, what it shows, the demo running in the
/// browser, and its listing.
/// </summary>
public class InputSection : BaseComponent<InputSectionProps, NoEvents, InputSectionSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new Section
            {
                Props = new SectionProps
                {
                    Class = "mt-12 scroll-mt-32 md:scroll-mt-20".ToConstSignal(),
                    Id = Props.Id.ToConstSignal(),
                },
                Children =
                [
                    new H3
                    {
                        Props = new H3Props
                        {
                            Class = "group relative flex flex-wrap items-baseline gap-x-3 gap-y-1 text-xl font-bold text-gray-900 dark:text-white".ToConstSignal(),
                        },
                        Children =
                        [
                            new A
                            {
                                Props = new AProps
                                {
                                    Href = $"#{Props.Id}".ToConstSignal(),
                                    Class = "absolute -left-5 opacity-0 group-hover:opacity-100 text-indigo-400 dark:text-indigo-500 no-underline transition-opacity".ToConstSignal(),
                                },
                                Children = [new DomText { Text = "#".ToConstSignal() }],
                            },
                            new DomText { Text = Props.Title.ToConstSignal() },
                            new Code
                            {
                                Props = new CodeProps
                                {
                                    Class = "rounded-md bg-gray-100 dark:bg-gray-800 px-2 py-0.5 font-mono text-xs font-medium text-indigo-700 dark:text-indigo-300".ToConstSignal(),
                                },
                                Children = [new DomText { Text = Props.Tag.ToConstSignal() }],
                            },
                        ],
                    },
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "mt-2 max-w-3xl leading-relaxed text-gray-600 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [new DomText { Text = Props.Description.ToConstSignal() }],
                    },
                    // The demo first, so it is in view before a long listing; the listing below
                    // it gets the full width, where its lines fit without scrolling sideways.
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "mt-5 flex flex-col gap-4".ToConstSignal(),
                        },
                        Children =
                        [
                            new LivePanel
                            {
                                Props = new LivePanelProps
                                {
                                    Label = "Live",
                                },
                                Slots = new LivePanelSlots
                                {
                                    Default = () => Slots?.Demo() ?? [],
                                },
                            },
                            new CSharpCode
                            {
                                Props = new CSharpCodeProps
                                {
                                    FileName = Props.FileName,
                                    Code = Props.Code,
                                },
                            },
                        ],
                    },
                ],
            },
        ];
    }
}
