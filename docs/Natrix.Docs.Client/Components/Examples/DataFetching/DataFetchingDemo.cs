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
        ];
    }
}
