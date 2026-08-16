using Natrix.Core;
using Natrix.Query.Tests.TestUtils;
using Natrix.Signals;
using Natrix.Ssr.RenderRoot;

using static Natrix.Query.NatrixQuery;

namespace Natrix.Query.Tests.Tests;

public class InfiniteQueryTests
{
    private sealed record Page(int Cursor, string[] Items, int? Next);

    private static Page MakePage(int cursor) =>
        new(cursor, [$"item {cursor}a", $"item {cursor}b"], cursor < 2 ? cursor + 1 : null);

    private static UseInfiniteQueryOptions<Page, int> Options(Action<int>? onFetch = null) => new()
    {
        QueryKey = ["projects"],
        InitialPageParam = 0,
        QueryFn = async context =>
        {
            onFetch?.Invoke(context.PageParam);
            await Task.Yield();
            return MakePage(context.PageParam);
        },
        GetNextPageParam = (lastPage, _, _, _) =>
            lastPage.Next is { } next ? next : NextPageParam<int>.None,
    };

    [Test]
    public async Task The_first_fetch_loads_one_page_with_the_initial_page_param()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var fetched = new List<int>();
            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(
                harness.Client,
                Options(fetched.Add));

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var result = observer.CurrentResult;
            await Assert.That(fetched).IsEquivalentTo(new[] { 0 });
            await Assert.That(result.Pages!.Pages.Count).IsEqualTo(1);
            await Assert.That(result.Pages.PageParams).IsEquivalentTo(new[] { 0 });
            await Assert.That(result.HasNextPage).IsTrue();
            await Assert.That(result.HasPreviousPage).IsFalse();
            await Assert.That(result.Status).IsEqualTo(QueryStatus.Success);
        });
    }

    [Test]
    public async Task Fetching_the_next_page_appends_it_and_reports_the_direction()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(
                harness.Client,
                Options());

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            var pending = observer.FetchNextPageAsync();

            await Assert.That(observer.CurrentResult.IsFetchingNextPage).IsTrue();
            await Assert.That(observer.CurrentResult.IsFetchingPreviousPage).IsFalse();

            await harness.SettleAsync();
            var result = await pending;

            await Assert.That(result.Pages!.Pages.Select(page => page.Cursor).ToArray())
                .IsEquivalentTo(new[] { 0, 1 });
            await Assert.That(result.IsFetchingNextPage).IsFalse();
            await Assert.That(result.HasNextPage).IsTrue();
        });
    }

    [Test]
    public async Task The_list_reports_when_it_has_reached_its_end()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(
                harness.Client,
                Options());

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await observer.FetchNextPageAsync();
            await harness.SettleAsync();
            await observer.FetchNextPageAsync();
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Pages!.Pages.Count).IsEqualTo(3);
            await Assert.That(observer.CurrentResult.HasNextPage).IsFalse();

            // Asking again past the end is a no-op rather than an error.
            await observer.FetchNextPageAsync();
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Pages!.Pages.Count).IsEqualTo(3);
        });
    }

    [Test]
    public async Task Refetching_replays_every_page_it_already_had()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var fetched = new List<int>();
            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(
                harness.Client,
                Options(fetched.Add));

            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await observer.FetchNextPageAsync();
            await harness.SettleAsync();

            fetched.Clear();

            await observer.RefetchAsync();
            await harness.SettleAsync();

            // Both pages come back, in order — the list does not collapse to its first page.
            await Assert.That(fetched).IsEquivalentTo(new[] { 0, 1 });
            await Assert.That(observer.CurrentResult.Pages!.Pages.Count).IsEqualTo(2);
        });
    }

    [Test]
    public async Task MaxPages_drops_the_far_end_of_the_list()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var options = new UseInfiniteQueryOptions<Page, int>
            {
                QueryKey = ["projects"],
                InitialPageParam = 0,
                MaxPages = 2,
                QueryFn = async context =>
                {
                    await Task.Yield();
                    return MakePage(context.PageParam);
                },
                GetNextPageParam = (lastPage, _, _, _) =>
                    lastPage.Next is { } next ? next : NextPageParam<int>.None,
            };

            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(harness.Client, options);
            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await observer.FetchNextPageAsync();
            await harness.SettleAsync();
            await observer.FetchNextPageAsync();
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Pages!.Pages.Select(page => page.Cursor).ToArray())
                .IsEquivalentTo(new[] { 1, 2 });
        });
    }

    [Test]
    public async Task Pages_can_be_fetched_backwards()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var options = new UseInfiniteQueryOptions<Page, int>
            {
                QueryKey = ["messages"],
                InitialPageParam = 5,
                QueryFn = async context =>
                {
                    await Task.Yield();
                    return new Page(context.PageParam, [$"message {context.PageParam}"], null);
                },
                GetNextPageParam = (_, _, _, _) => NextPageParam<int>.None,
                GetPreviousPageParam = (firstPage, _, _, _) =>
                    firstPage.Cursor > 0 ? firstPage.Cursor - 1 : NextPageParam<int>.None,
            };

            var observer = new InfiniteQueryObserver<Page, int, InfiniteData<Page, int>>(harness.Client, options);
            using var subscription = observer.Subscribe(_ => { });
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.HasPreviousPage).IsTrue();
            await Assert.That(observer.CurrentResult.HasNextPage).IsFalse();

            await observer.FetchPreviousPageAsync();
            await harness.SettleAsync();

            await Assert.That(observer.CurrentResult.Pages!.Pages.Select(page => page.Cursor).ToArray())
                .IsEquivalentTo(new[] { 4, 5 });
        });
    }

    [Test]
    public async Task A_component_can_flatten_the_pages_with_Select()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            UseInfiniteQueryResult<Page, int, string[]>? projects = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => projects = UseInfiniteQuery(
                            new UseInfiniteQueryOptions<Page, int, string[]>
                            {
                                QueryKey = ["projects"],
                                InitialPageParam = 0,
                                QueryFn = async context =>
                                {
                                    await Task.Yield();
                                    return MakePage(context.PageParam);
                                },
                                GetNextPageParam = (lastPage, _, _, _) =>
                                    lastPage.Next is { } next ? next : NextPageParam<int>.None,
                                Select = pages => pages.Pages.SelectMany(page => page.Items).ToArray(),
                            }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();

            await Assert.That(projects!.Data.Value!.Length).IsEqualTo(2);
            await Assert.That(projects.HasNextPage.Value).IsTrue();

            await projects.FetchNextPageAsync();
            await harness.SettleAsync();

            await Assert.That(projects.Data.Value!.Length).IsEqualTo(4);
            await Assert.That(projects.Pages.Value!.Pages.Count).IsEqualTo(2);
        });
    }

    [Test]
    public async Task A_reactive_key_starts_a_fresh_list()
    {
        await QueryTestHarness.RunAsync(async harness =>
        {
            var owner = new Signal<string>("alice");
            UseInfiniteQueryResult<Page, int, InfiniteData<Page, int>>? projects = null;

            using var app = new NatrixHostBuilder()
                .UseRootRenderer(new SsrRenderRoot())
                .UseLifecycleHooks()
                .UseQueryClient(harness.Client)
                .UseRootComponent(() => new Probe
                {
                    Props = new ProbeProps
                    {
                        Setup = () => projects = UseInfiniteQuery(() => new UseInfiniteQueryOptions<Page, int>
                        {
                            QueryKey = ["projects", owner.Value],
                            InitialPageParam = 0,
                            QueryFn = async context =>
                            {
                                await Task.Yield();
                                return MakePage(context.PageParam);
                            },
                            GetNextPageParam = (lastPage, _, _, _) =>
                                lastPage.Next is { } next ? next : NextPageParam<int>.None,
                        }),
                    },
                })
                .Build()
                .Mount();

            await harness.SettleAsync();
            await projects!.FetchNextPageAsync();
            await harness.SettleAsync();

            await Assert.That(projects.Pages.Value!.Pages.Count).IsEqualTo(2);

            owner.Value = "bob";
            await harness.SettleAsync();

            await Assert.That(projects.Pages.Value!.Pages.Count).IsEqualTo(1);

            // The first owner's pages are still cached under their own key.
            var cached = harness.Client.GetQueryData<InfiniteData<Page, int>>(["projects", "alice"]);
            await Assert.That(cached!.Pages.Count).IsEqualTo(2);
        });
    }
}
