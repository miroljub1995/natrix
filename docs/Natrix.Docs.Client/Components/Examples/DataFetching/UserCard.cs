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

        var hasError = new Computed<bool>(() => user.Error.Value is not null);
        var hasProfile = new Computed<bool>(() => user.Data.Value is not null);

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
                    new CardHeading
                    {
                        Props = new CardHeadingProps { Label = Props.Label, Status = status },
                    },

                    // An error does not replace what is already on screen. A failed revalidation
                    // leaves the last good profile in place and adds the banner above it; only a
                    // key that has never resolved has nothing to show but the error.
                    new If
                    {
                        Condition = hasError,
                        Then = () =>
                        [
                            new ErrorBanner
                            {
                                Props = new ErrorBannerProps
                                {
                                    Message = new Computed<string>(
                                        () => user.Error.Value?.Message ?? string.Empty),
                                },
                            },
                        ],
                    },

                    // The stale value stays put while a revalidation runs, so the skeleton only
                    // appears before the very first value for a key arrives.
                    new If
                    {
                        Condition = user.IsLoading,
                        Then = () => [new ProfileSkeleton { Props = new NoProps() }],
                        Otherwise = () =>
                        [
                            new If
                            {
                                Condition = hasProfile,
                                Then = () =>
                                [
                                    new ProfileDetails
                                    {
                                        Props = new ProfileDetailsProps { Profile = user.Data },
                                    },
                                ],
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
}
