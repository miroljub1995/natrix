using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class DataFetchingExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new ExamplePage
            {
                Props = new ExamplePageProps
                {
                    Title = "Data Fetching".ToConstSignal(),
                    Id = "data-fetching-example".ToConstSignal(),
                    Description = ("Stale-while-revalidate fetching with Natrix.Swr, over a real endpoint. "
                        + "The server called it while rendering this page and sent the result along, so both "
                        + "cards started filled in without the browser asking for anything. They bind to the "
                        + "same key, so they share one request and one cached value: switching users refetches "
                        + "once for both, and switching back renders from cache while it revalidates. Break the "
                        + "API to watch the resource retry twice before it surfaces the error, and use "
                        + "'+1 follower' to write straight into the shared cache entry.").ToConstSignal(),
                    GitHubUrl = "https://github.com/miroljub1995/natrix/tree/main/docs/Natrix.Docs.Client/Components/Examples/DataFetching".ToConstSignal(),
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () => [new DataFetchingDemo { Props = new NoProps() }],
                },
            },
        ];
    }
}
