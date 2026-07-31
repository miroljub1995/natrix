using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components;

public class HomePageProps { }

public class HomePage : BaseComponent<HomePageProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        new Effect((onCleanup) =>
        {
            var text = "Home page";
            Console.WriteLine(text);
            onCleanup(() => Console.WriteLine("Cleanup " + text));
        });

        return
        [
            new H1
            {
                Props = new H1Props
                {
                    Id = "home".ToConstSignal(),
                    Class = "group relative text-4xl font-bold text-gray-900 dark:text-white mb-6".ToConstSignal(),
                },
                Children =
                [
                    new A
                    {
                        Props = new AProps
                        {
                            Href = "#home".ToConstSignal(),
                            Class = "absolute -left-6 opacity-0 group-hover:opacity-100 text-indigo-400 dark:text-indigo-500 no-underline transition-opacity".ToConstSignal(),
                        },
                        Children = [new DomText { Text = "#".ToConstSignal() }],
                    },
                    new DomText { Text = "Home".ToConstSignal() },
                ],
            },
            new SectionTitle
            {
                Props = new SectionTitleProps
                {
                    Text = "Home".ToConstSignal(),
                    Id = "home".ToConstSignal(),
                },
                Slots = new SectionTitleSlots
                {
                    Default = () =>
                    [
                        new P
                        {
                            Props = new PProps
                            {
                                Class = "text-gray-600 dark:text-white".ToConstSignal(),
                            },
                            Children = [new DomText { Text = "Welcome to Natrix — a reactive UI framework for .NET.".ToConstSignal() }],
                        },
                    ],
                },
            },
        ];
    }
}
