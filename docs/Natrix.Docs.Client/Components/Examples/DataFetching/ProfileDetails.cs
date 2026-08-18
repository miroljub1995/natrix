using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public class ProfileDetailsProps
{
    /// <summary>
    /// The cached profile. Nullable because a key that has only ever failed has none, and
    /// because the value survives a failed revalidation rather than being cleared.
    /// </summary>
    public required IReadOnlySignal<UserProfile?> Profile { get; init; }
}

/// <summary>
/// Renders a profile. Takes the value rather than the resource: it has no say in when the data
/// is fetched, so it has no business holding something that could refetch it.
/// </summary>
public class ProfileDetails : BaseComponent<ProfileDetailsProps, NoEvents, NoSlots, NoExpose>
{
    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
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
                                Text = new Computed<string>(() => Props.Profile.Value?.Name ?? "—"),
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
                                Text = new Computed<string>(() => Props.Profile.Value is { } profile
                                    ? $"{profile.Role} · {profile.Followers} followers"
                                    : string.Empty),
                            },
                        ],
                    },
                ],
            },
        ];
    }
}
