using Natrix.Core;
using Natrix.Core.Components;
using Natrix.Core.RenderRoot;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Browser.Tests;

/// <summary>
/// Mounted hooks are collected during a mount pass and flushed once the tree is complete.
/// These tests pin the resulting contract: ambient state inside a hook, ordering,
/// batching of hooks queued by other hooks, and liveness of the owning component.
/// </summary>
public class LifecycleHooksTests
{
    private sealed class ProbeProps
    {
        public Func<IComponent[]>? Body { get; init; }
        public Action<Action<Action>>[]? Mounted { get; init; }
        public Action? Unmounted { get; init; }
    }

    private sealed class Probe : BaseComponent<ProbeProps, NoEvents, NoSlots, NoExpose>
    {
        protected override IComponent[] Setup(out NoExpose exposed)
        {
            exposed = default;

            foreach (var mounted in Props.Mounted ?? [])
            {
                OnMounted(mounted);
            }

            if (Props.Unmounted is not null)
            {
                OnUnmounted(Props.Unmounted);
            }

            return Props.Body?.Invoke() ?? [];
        }
    }

    private static Probe CreateProbe(
        Action<Action<Action>>? mounted = null,
        Action? unmounted = null,
        Func<IComponent[]>? body = null) => new()
        {
            Props = new ProbeProps
            {
                Mounted = mounted is null ? null : [mounted],
                Unmounted = unmounted,
                Body = body,
            },
        };

    private static NatrixHost BuildHost(Element container, Func<IComponent> componentFactory)
    {
        return new NatrixHostBuilder()
            .UseRootRenderer(new DomRenderRoot(container))
            .UseLifecycleHooks()
            .UseRootComponent(componentFactory)
            .Build();
    }

    private static Probe CreateRoot(params IComponent[] children) =>
        CreateProbe(body: () => children);

    [Test]
    public async Task Creating_an_Effect_inside_a_mounted_hook_is_rejected()
    {
        var container = DomHelpers.CreateContainer();
        System.Exception? captured = null;

        using var _ = BuildHost(container, () => CreateProbe(mounted: _ =>
        {
            try
            {
                new Effect(_ => { });
            }
            catch (System.Exception e)
            {
                captured = e;
            }
        })).Mount();

        // Hooks run detached, so an effect declared there would belong to no component
        // and never be disposed. The reactive graph is declared in Setup instead.
        await Assert.That(captured).IsNotNull();
    }

    [Test]
    public async Task Creating_an_Effect_inside_an_unmounted_hook_is_rejected()
    {
        var container = DomHelpers.CreateContainer();
        System.Exception? captured = null;

        using (var _ = BuildHost(container, () => CreateProbe(unmounted: () =>
        {
            try
            {
                new Effect(_ => { });
            }
            catch (System.Exception e)
            {
                captured = e;
            }
        })).Mount())
        {
            await Assert.That(captured).IsNull();
        }

        await Assert.That(captured).IsNotNull();
    }

    [Test]
    public async Task Signal_read_inside_OnMounted_does_not_re_trigger_the_component()
    {
        var container = DomHelpers.CreateContainer();
        var tracked = new Signal<int>(0);
        var mountedRuns = 0;
        var lastRead = -1;
        var childSetups = 0;
        var childUnmounts = 0;

        using var _ = BuildHost(container, () => CreateProbe(
            mounted: _ =>
            {
                lastRead = tracked.Value;
                mountedRuns++;
            },
            body: () =>
            {
                childSetups++;
                return [CreateProbe(unmounted: () => childUnmounts++)];
            })).Mount();

        await Assert.That(mountedRuns).IsEqualTo(1);
        await Assert.That(lastRead).IsEqualTo(0);

        tracked.Value = 1;

        // Had the hook been tracked, the component's mount effect would have re-run,
        // tearing down and rebuilding its children.
        await Assert.That(mountedRuns).IsEqualTo(1);
        await Assert.That(childSetups).IsEqualTo(1);
        await Assert.That(childUnmounts).IsEqualTo(0);
    }

    [Test]
    public async Task Hooks_run_bottom_up()
    {
        var container = DomHelpers.CreateContainer();
        var order = new List<string>();

        using var _ = BuildHost(container, () => CreateProbe(
            mounted: _ => order.Add("outer"),
            body: () =>
            [
                CreateProbe(
                    mounted: _ => order.Add("middle"),
                    body: () => [CreateProbe(mounted: _ => order.Add("inner"))]),
            ])).Mount();

        await Assert.That(order).IsEquivalentTo(new List<string> { "inner", "middle", "outer" });
    }

    [Test]
    public async Task Hook_of_a_component_unmounted_during_the_flush_is_skipped()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(true);
        var hidden = 0;
        var hiddenUnmounted = 0;

        using var _ = BuildHost(container, () => CreateRoot(
            // Mounts first, so its hook is queued ahead of the If branch's hook.
            CreateProbe(mounted: _ => show.Value = false),
            new If
            {
                Condition = show,
                Then = () =>
                [
                    CreateProbe(
                        mounted: _ => hidden++,
                        unmounted: () => hiddenUnmounted++),
                ],
            })).Mount();

        await Assert.That(hidden).IsEqualTo(0);

        // The mounted hook is skipped, but Setup already ran, so its cleanup still runs.
        await Assert.That(hiddenUnmounted).IsEqualTo(1);
    }

    [Test]
    public async Task Later_hook_is_skipped_when_an_earlier_one_unmounts_its_component()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(true);
        var first = 0;
        var second = 0;

        using var _ = BuildHost(container, () => CreateRoot(
            new If
            {
                Condition = show,
                Then = () =>
                [
                    new Probe
                    {
                        Props = new ProbeProps
                        {
                            Mounted =
                            [
                                _ => { first++; show.Value = false; },
                                _ => second++,
                            ],
                        },
                    },
                ],
            })).Mount();

        await Assert.That(first).IsEqualTo(1);
        await Assert.That(second).IsEqualTo(0);
    }

    [Test]
    public async Task Hooks_queued_by_a_hook_join_the_end_of_the_same_batch()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(false);
        var order = new List<string>();

        using var _ = BuildHost(container, () => CreateRoot(
            CreateProbe(mounted: _ =>
            {
                order.Add("a");
                show.Value = true;
            }),
            new If
            {
                Condition = show,
                Then = () => [CreateProbe(mounted: _ => order.Add("b"))],
            },
            CreateProbe(mounted: _ => order.Add("c")))).Mount();

        // "b" is mounted by "a" and must be appended after the already-queued "c"
        // rather than running nested inside "a".
        await Assert.That(order).IsEquivalentTo(new List<string> { "a", "c", "b" });
    }

    [Test]
    public async Task Component_mounted_after_the_initial_pass_still_runs_its_hooks()
    {
        var container = DomHelpers.CreateContainer();
        var show = new Signal<bool>(false);
        var mounted = 0;
        var unmounted = 0;

        using var _ = BuildHost(container, () => CreateRoot(
            new If
            {
                Condition = show,
                Then = () =>
                [
                    CreateProbe(mounted: _ => mounted++, unmounted: () => unmounted++),
                ],
            })).Mount();

        await Assert.That(mounted).IsEqualTo(0);

        show.Value = true;
        await Assert.That(mounted).IsEqualTo(1);

        show.Value = false;
        await Assert.That(unmounted).IsEqualTo(1);
    }

    [Test]
    public async Task OnUnmounted_registered_in_Setup_runs_after_a_normal_mount()
    {
        var container = DomHelpers.CreateContainer();
        var unmounted = 0;

        using (var _ = BuildHost(container, () => CreateProbe(unmounted: () => unmounted++)).Mount())
        {
            await Assert.That(unmounted).IsEqualTo(0);
        }

        await Assert.That(unmounted).IsEqualTo(1);
    }
}
