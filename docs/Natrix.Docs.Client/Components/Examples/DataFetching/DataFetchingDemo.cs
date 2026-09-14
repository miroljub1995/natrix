using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class DataFetchingDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var selectedId = new Signal<string>("ada");

        // Owned here rather than by the API: it is a control on this demo, not a mode the service
        // is in. The cards read it to decide which endpoint to call.
        var useFailingEndpoint = new Signal<bool>(false);

        return
        [
            new Div
            {
                Props = new DivProps { Class = "space-y-6".ToConstSignal() },
                Children =
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
                                    Children =
                                    [
                                        new UserPicker
                                        {
                                            Props = new UserPickerProps { SelectedId = selectedId },
                                            Events = new UserPickerEvents
                                            {
                                                OnSelect = id => selectedId.Value = id,
                                            },
                                        },
                                        new ApiHealthToggle
                                        {
                                            Props = new ApiHealthToggleProps { UseFailingEndpoint = useFailingEndpoint },
                                            Events = new ApiHealthToggleEvents
                                            {
                                                OnToggle = () => useFailingEndpoint.Value = !useFailingEndpoint.Value,
                                            },
                                        },
                                    ],
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
                                                UserId = selectedId,
                                                Label = "Card A".ToConstSignal(),
                                                UseFailingEndpoint = useFailingEndpoint,
                                            },
                                        },
                                        new UserCard
                                        {
                                            Props = new UserCardProps
                                            {
                                                UserId = selectedId,
                                                Label = "Card B".ToConstSignal(),
                                                UseFailingEndpoint = useFailingEndpoint,
                                            },
                                        },
                                    ],
                                },

                                new P
                                {
                                    Props = new PProps
                                    {
                                        Class = "mt-4 text-sm text-gray-500 dark:text-gray-500".ToConstSignal(),
                                    },
                                    Children =
                                    [
                                        new DomText
                                        {
                                            Text = ("Both cards were filled in by the server before this page was sent, "
                                                + "so the browser fetched nothing to show them. Switching users sends one "
                                                + "request for both cards; switching back renders from cache.")
                                                .ToConstSignal(),
                                        },
                                    ],
                                },
                            ],
                        },
                    },

                    new DemoCard
                    {
                        Props = new DemoCardProps
                        {
                            Title = "Two keys, one component".ToConstSignal(),
                        },
                        Slots = new DemoCardSlots
                        {
                            Default = () =>
                            [
                                new Div
                                {
                                    Props = new DivProps { Class = "grid gap-4 sm:grid-cols-2".ToConstSignal() },
                                    Children =
                                    [
                                        new UserGroupCard
                                {
                                    Props = new UserGroupCardProps
                                    {
                                        UserIds = ["ada", "grace"],
                                        Label = "Ada + Grace".ToConstSignal(),
                                    },
                                },
                                new UserGroupCard
                                {
                                    Props = new UserGroupCardProps
                                    {
                                        UserIds = ["grace", "linus"],
                                        Label = "Grace + Linus".ToConstSignal(),
                                    },
                                },
                                    ],
                                },

                                new P
                                {
                                    Props = new PProps
                                    {
                                        Class = "mt-4 text-sm text-gray-500 dark:text-gray-500".ToConstSignal(),
                                    },
                                    Children =
                                    [
                                        new DomText
                                        {
                                            Text = ("Each card binds two keys, and both requests go out at the same time "
                                                + "rather than one after the other. Grace is in both pairs, so the two "
                                                + "cards cost three requests between them, not four, and her card above "
                                                + "shares the same entry: '+1 follower' there shows up here too.")
                                                .ToConstSignal(),
                                        },
                                    ],
                                },
                            ],
                        },
                    },

                    new DemoCard
                    {
                        Props = new DemoCardProps
                        {
                            Title = "Client only".ToConstSignal(),
                        },
                        Slots = new DemoCardSlots
                        {
                            Default = () =>
                            [
                                new Div
                                {
                                    Props = new DivProps { Class = "grid gap-4 sm:grid-cols-2".ToConstSignal() },
                                    Children =
                                    [
                                        new UserGroupCard
                                        {
                                            Props = new UserGroupCardProps
                                            {
                                                UserIds = ["alan", "margaret"],
                                                Label = "Alan + Margaret".ToConstSignal(),
                                                FetchOnServer = false,
                                            },
                                        },
                                    ],
                                },

                                new P
                                {
                                    Props = new PProps
                                    {
                                        Class = "mt-4 text-sm text-gray-500 dark:text-gray-500".ToConstSignal(),
                                    },
                                    Children =
                                    [
                                        new DomText
                                        {
                                            Text = ("This card turns FetchOnServer off, so the server rendered its "
                                                + "skeletons rather than calling the API, and the browser fetched both "
                                                + "users after the page hydrated. Reload to watch IsLoading go true.")
                                                .ToConstSignal(),
                                        },
                                    ],
                                },
                            ],
                        },
                    },
                ],
            },
        ];
    }
}
