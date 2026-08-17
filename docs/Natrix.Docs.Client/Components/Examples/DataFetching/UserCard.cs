using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.Swr;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class UserCardProps
{
    public required FakeUserApi Api { get; init; }

    /// <summary>
    /// Part of the key, so changing it makes the card follow the selected user.
    /// </summary>
    public required IReadOnlySignal<string> UserId { get; init; }

    public required IReadOnlySignal<string> Label { get; init; }
}

/// <summary>
/// A card bound to one user through <c>SwrResource.Use</c>. Two of these mounted side by side on
/// the same key share a cache entry, so they issue one request between them and update together.
/// </summary>
public class UserCard : BaseComponent<UserCardProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var user = SwrResource.Use(
            () => ["docs-demo", "user", Props.UserId.Value],
            (key, cancellationToken) => Props.Api.GetUserAsync(key[2], cancellationToken),
            new SwrOptions { ErrorRetryCount = 2, ErrorRetryInterval = TimeSpan.FromSeconds(1) });

        var status = new Computed<string>(() =>
            user.IsLoading.Value ? "loading"
            : user.IsValidating.Value ? "revalidating"
            : user.Error.Value is not null ? "error"
            : "ready");

        var statusClass = new Computed<string>(() =>
        {
            const string baseClass = "rounded-full px-2 py-0.5 text-xs font-medium";

            return status.Value switch
            {
                "loading" or "revalidating" =>
                    $"{baseClass} bg-amber-100 text-amber-800 dark:bg-amber-900/40 dark:text-amber-300",
                "error" =>
                    $"{baseClass} bg-red-100 text-red-800 dark:bg-red-900/40 dark:text-red-300",
                _ =>
                    $"{baseClass} bg-emerald-100 text-emerald-800 dark:bg-emerald-900/40 dark:text-emerald-300",
            };
        });

        return
        [
            new Div
            {
                Props = new DivProps
                {
                    Class = "rounded-lg border border-gray-200 dark:border-gray-700 p-4".ToConstSignal(),
                },
                Children =
                [
                    new Div
                    {
                        Props = new DivProps
                        {
                            Class = "mb-3 flex items-center justify-between gap-2".ToConstSignal(),
                        },
                        Children =
                        [
                            new Span
                            {
                                Props = new SpanProps
                                {
                                    Class = "text-sm font-semibold text-gray-500 dark:text-gray-400".ToConstSignal(),
                                },
                                Children = [new DomText { Text = Props.Label }],
                            },
                            new Span
                            {
                                Props = new SpanProps { Class = statusClass },
                                Children = [new DomText { Text = status }],
                            },
                        ],
                    },

                    // An error does not replace what is already on screen. A failed revalidation
                    // leaves the last good profile in place and adds the banner above it; only a
                    // key that has never resolved has nothing to show but the error.
                    new If
                    {
                        Condition = new Computed<bool>(() => user.Error.Value is not null),
                        Then = () =>
                        [
                            new P
                            {
                                Props = new PProps
                                {
                                    Class = ("mb-3 rounded-md bg-red-50 px-3 py-2 text-sm text-red-700 "
                                        + "dark:bg-red-900/30 dark:text-red-300").ToConstSignal(),
                                },
                                Children =
                                [
                                    new DomText
                                    {
                                        Text = new Computed<string>(
                                            () => user.Error.Value?.Message ?? string.Empty),
                                    },
                                ],
                            },
                        ],
                    },

                    // The stale value stays put while a revalidation runs, so the placeholder only
                    // appears before the very first value for a key arrives.
                    new If
                    {
                        Condition = user.IsLoading,
                        Then = () => [Placeholder()],
                        Otherwise = () =>
                        [
                            new If
                            {
                                Condition = new Computed<bool>(() => user.Data.Value is not null),
                                Then = () => [Profile(user)],
                            },
                        ],
                    },

                    new Div
                    {
                        Props = new DivProps { Class = "mt-4 flex flex-wrap gap-2".ToConstSignal() },
                        Children =
                        [
                            new DemoButton
                            {
                                Props = new DemoButtonProps
                                {
                                    Label = "Revalidate".ToConstSignal(),
                                    Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                                    ExtraClass = "px-3 py-1 text-sm".ToConstSignal(),
                                    Title = "Refetches, or joins the request already in flight".ToConstSignal(),
                                },
                                Events = new DemoButtonEvents
                                {
                                    // Fire and forget: the resource's signals report the outcome.
                                    OnClick = () => user.RevalidateAsync(),
                                },
                            },
                            new DemoButton
                            {
                                Props = new DemoButtonProps
                                {
                                    Label = "+1 follower".ToConstSignal(),
                                    Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                                    ExtraClass = "px-3 py-1 text-sm".ToConstSignal(),
                                    Title = "Writes into the shared cache entry without refetching".ToConstSignal(),
                                },
                                Events = new DemoButtonEvents
                                {
                                    OnClick = () => user.MutateAsync(
                                        current => current is null
                                            ? new UserProfile("Unknown", "—", 1)
                                            : current with { Followers = current.Followers + 1 },
                                        revalidate: false),
                                },
                            },
                        ],
                    },
                ],
            },
        ];
    }

    private static IComponent Placeholder() =>
        new Div
        {
            Props = new DivProps { Class = "space-y-2".ToConstSignal() },
            Children =
            [
                new Div
                {
                    Props = new DivProps
                    {
                        Class = "h-5 w-40 animate-pulse rounded bg-gray-200 dark:bg-gray-700".ToConstSignal(),
                    },
                },
                new Div
                {
                    Props = new DivProps
                    {
                        Class = "h-4 w-28 animate-pulse rounded bg-gray-200 dark:bg-gray-700".ToConstSignal(),
                    },
                },
            ],
        };

    private static IComponent Profile(SwrResource<UserProfile> user) =>
        new Div
        {
            Props = new DivProps { Class = "space-y-1".ToConstSignal() },
            Children =
            [
                new P
                {
                    Props = new PProps
                    {
                        Class = "text-lg font-semibold text-gray-900 dark:text-white".ToConstSignal(),
                    },
                    Children =
                    [
                        new DomText
                        {
                            Text = new Computed<string>(() => user.Data.Value?.Name ?? "—"),
                        },
                    ],
                },
                new P
                {
                    Props = new PProps
                    {
                        Class = "text-sm text-gray-600 dark:text-gray-400".ToConstSignal(),
                    },
                    Children =
                    [
                        new DomText
                        {
                            Text = new Computed<string>(() =>
                                user.Data.Value is { } profile
                                    ? $"{profile.Role} · {profile.Followers} followers"
                                    : string.Empty),
                        },
                    ],
                },
            ],
        };
}
