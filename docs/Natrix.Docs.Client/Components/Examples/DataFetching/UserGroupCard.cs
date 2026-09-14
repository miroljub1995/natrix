using Natrix.Core.Components;
using Natrix.Core.Features;
using Natrix.Docs.Contracts;
using Natrix.Dom.Components;
using Natrix.Signals;
using Natrix.Swr;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class UserGroupCardProps
{
    /// <summary>
    /// The users the card binds, one resource each. Fixed for the life of the card: the group is
    /// the card's identity, not something the demo changes under it.
    /// </summary>
    public required IReadOnlyList<string> UserIds { get; init; }

    public required IReadOnlySignal<string> Label { get; init; }

    /// <summary>
    /// Whether the server fetches the group while rendering the page. <see langword="false"/>
    /// makes every resource in the card client-only: the page arrives with skeletons in this
    /// card and the browser fetches them after hydration.
    /// </summary>
    public bool FetchOnServer { get; init; } = true;
}

/// <summary>
/// A card bound to several users at once. Each <c>SwrResource.Use</c> is its own resource with
/// its own request, so they all go out in parallel rather than one after the other, and each key
/// is still shared with every other component on it — including the group card next door and
/// the cards in the demo above.
/// </summary>
public class UserGroupCard : BaseComponent<UserGroupCardProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var api = AppFeatures.Features.GetRequired<UserApi>();

        // Same key shape as UserCard, so a user in a group is the same cache entry as that user
        // picked above: one request between all of them, and a mutation in one shows in all.
        var users = Props.UserIds
            .Select(id => SwrResource.Use(
                () => ("docs-demo", "user", id),
                (key, cancellationToken) => api.GetUserAsync(key.Item3, cancellationToken),
                options => options with { FetchOnServer = Props.FetchOnServer }))
            .ToList();

        // The ids are lower-case; the badge row wants the name the picker shows.
        static string DisplayName(string id) =>
            id.Length == 0 ? string.Empty : char.ToUpperInvariant(id[0]) + id[1..];

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
                    // No flags of its own: each query below carries them, so the members can be
                    // seen loading and revalidating independently.
                    new P
                    {
                        Props = new PProps
                        {
                            Class = "mb-3 text-sm font-semibold text-gray-500 dark:text-gray-400".ToConstSignal(),
                        },
                        Children = [new DomText { Text = Props.Label }],
                    },

                    new Div
                    {
                        Props = new DivProps { Class = "space-y-4".ToConstSignal() },
                        Children =
                        [
                            .. Props.UserIds.Zip(users, (id, user) => new GroupMember
                            {
                                Props = new GroupMemberProps
                                {
                                    Label = DisplayName(id).ToConstSignal(),
                                    User = user,
                                },
                            }),
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
                                    Label = "Revalidate all".ToConstSignal(),
                                    Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                                    ExtraClass = "px-3 py-1 text-sm".ToConstSignal(),
                                    Title = "Refetches every user in the card at once".ToConstSignal(),
                                },
                                Events = new DemoButtonEvents
                                {
                                    // All start on the same tick; none waits for another. Fire and
                                    // forget: the resources' signals report the outcome.
                                    OnClick = () => Task.WhenAll(users.Select(user => user.RevalidateAsync())),
                                },
                            },
                        ],
                    },
                ],
            },
        ];
    }
}

public class GroupMemberProps
{
    public required IReadOnlySignal<string> Label { get; init; }

    public required SwrResource<UserProfile> User { get; init; }
}

/// <summary>
/// One member of a group, with its own flags: the skeleton until the key's first value
/// arrives, then the profile, which stays put while that key revalidates.
/// </summary>
public class GroupMember : BaseComponent<GroupMemberProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        var user = Props.User;
        var hasProfile = new Computed<bool>(() => user.Data.Value is not null);

        return
        [
            new CardHeading
            {
                Props = new CardHeadingProps
                {
                    Label = Props.Label,
                    IsLoading = user.IsLoading,
                    IsValidating = user.IsValidating,
                },
            },
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
        ];
    }
}
