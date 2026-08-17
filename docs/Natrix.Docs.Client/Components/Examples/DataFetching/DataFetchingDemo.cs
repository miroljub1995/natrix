using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class DataFetchingDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    private static readonly (string Id, string Name)[] Users =
    [
        ("ada", "Ada"),
        ("grace", "Grace"),
        ("linus", "Linus"),
    ];

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var api = new FakeUserApi();
        var selectedId = new Signal<string>("ada");

        return
        [
            new DemoCard
            {
                Props = new DemoCardProps
                {
                    Title = "Two components, one key".ToConstSignal(),
                },
                Slots = new DemoCardSlots
                {
                    Default = () =>
                    [
                        new Div
                        {
                            Props = new DivProps { Class = "mb-4 flex flex-wrap items-center gap-2".ToConstSignal() },
                            Children = [.. UserPicker(selectedId), BreakToggle(api)],
                        },

                        new Div
                        {
                            Props = new DivProps { Class = "grid gap-4 sm:grid-cols-2".ToConstSignal() },
                            Children =
                            [
                                new UserCard
                                {
                                    Props = new UserCardProps
                                    {
                                        Api = api,
                                        UserId = selectedId,
                                        Label = "Card A".ToConstSignal(),
                                    },
                                },
                                new UserCard
                                {
                                    Props = new UserCardProps
                                    {
                                        Api = api,
                                        UserId = selectedId,
                                        Label = "Card B".ToConstSignal(),
                                    },
                                },
                            ],
                        },

                        new P
                        {
                            Props = new PProps
                            {
                                Class = "mt-4 text-sm text-gray-600 dark:text-gray-400".ToConstSignal(),
                            },
                            Children =
                            [
                                new DomText
                                {
                                    Text = new Computed<string>(() =>
                                        $"Requests actually sent: {api.RequestCount.Value}"),
                                },
                            ],
                        },
                        new P
                        {
                            Props = new PProps
                            {
                                Class = "mt-1 text-sm text-gray-500 dark:text-gray-500".ToConstSignal(),
                            },
                            Children =
                            [
                                new DomText
                                {
                                    Text = ("Switching users sends one request for both cards. Switching back "
                                        + "renders the cached value straight away and revalidates behind it.")
                                        .ToConstSignal(),
                                },
                            ],
                        },
                    ],
                },
            },
        ];
    }

    private static IComponent[] UserPicker(Signal<string> selectedId)
    {
        var buttons = new List<IComponent>();

        foreach (var (id, name) in Users)
        {
            buttons.Add(new DemoButton
            {
                Props = new DemoButtonProps
                {
                    Label = name.ToConstSignal(),
                    Variant = new Computed<DemoButtonVariant>(() => selectedId.Value == id
                        ? DemoButtonVariant.Primary
                        : DemoButtonVariant.Secondary),
                    ExtraClass = "px-4 py-1 text-sm".ToConstSignal(),
                },
                Events = new DemoButtonEvents
                {
                    OnClick = () => selectedId.Value = id,
                },
            });
        }

        return [.. buttons];
    }

    private static IComponent BreakToggle(FakeUserApi api) =>
        new DemoButton
        {
            Props = new DemoButtonProps
            {
                Label = new Computed<string>(() => api.IsBroken.Value ? "Repair the API" : "Break the API"),
                Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                ExtraClass = "ml-auto px-4 py-1 text-sm".ToConstSignal(),
                Title = "While broken, every request fails and the resource retries twice before giving up"
                    .ToConstSignal(),
            },
            Events = new DemoButtonEvents
            {
                OnClick = () => api.IsBroken.Value = !api.IsBroken.Value,
            },
        };
}
