using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

public class ExamplePageProps
{
    public required IReadOnlySignal<string> Title { get; init; }
    public required IReadOnlySignal<string> Id { get; init; }
    public required IReadOnlySignal<string> Description { get; init; }
    public required IReadOnlySignal<string> GitHubUrl { get; init; }
}

public class ExamplePageSlots
{
    public required Func<IComponent[]> Demo { get; init; }
}

public class ExamplePage : BaseComponent<ExamplePageProps, NoEvents, ExamplePageSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new H1
            {
                Props = new H1Props
                {
                    Id = Props.Id,
                    Class = "group relative text-4xl font-bold text-gray-900 dark:text-white mb-6".ToConstSignal(),
                },
                Children =
                [
                    new A
                    {
                        Props = new AProps
                        {
                            Href = new Computed<string>(() => $"#{Props.Id.Value}"),
                            Class = "absolute -left-6 opacity-0 group-hover:opacity-100 text-indigo-400 dark:text-indigo-500 no-underline transition-opacity".ToConstSignal(),
                        },
                        Children = [new DomText { Text = "#".ToConstSignal() }],
                    },
                    new DomText { Text = Props.Title },
                    new A
                    {
                        Props = new AProps
                        {
                            Href = Props.GitHubUrl,
                            Class = "ml-3 inline-flex align-baseline text-gray-500 dark:text-gray-400 hover:text-indigo-600 dark:hover:text-indigo-400 no-underline transition-colors".ToConstSignal(),
                            Title = "View example on GitHub".ToConstSignal(),
                        },
                        Children =
                        [
                            new Img
                            {
                                Props = new ImgProps
                                {
                                    Src = "/assets/github-mark.svg".ToConstSignal(),
                                    Alt = "GitHub".ToConstSignal(),
                                    Class = "h-5 w-5 dark:invert".ToConstSignal(),
                                },
                            },
                        ],
                    },
                ],
            },
            new P
            {
                Props = new PProps
                {
                    Class = "mb-6 text-gray-600 dark:text-gray-400".ToConstSignal(),
                },
                Children = [new DomText { Text = Props.Description }],
            },
            new SectionTitle
            {
                Props = new SectionTitleProps
                {
                    Text = "Demo".ToConstSignal(),
                    Id = new Computed<string>(() => $"{Props.Id.Value}-demo"),
                },
                Slots = new SectionTitleSlots
                {
                    Default = () => Slots?.Demo() ?? [],
                },
            },
        ];
    }
}
