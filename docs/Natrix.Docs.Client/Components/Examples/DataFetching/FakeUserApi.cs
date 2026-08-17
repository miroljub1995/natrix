using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

public sealed record UserProfile(string Name, string Role, int Followers);

/// <summary>
/// Stands in for a real HTTP client. It is slow on purpose, counts its calls so the demo can show
/// how few requests SWR actually makes, and can be told to fail so the retry behaviour is visible.
/// </summary>
public sealed class FakeUserApi
{
    private static readonly Dictionary<string, UserProfile> Profiles = new()
    {
        ["ada"] = new("Ada Lovelace", "Mathematician", 1843),
        ["grace"] = new("Grace Hopper", "Rear Admiral", 1959),
        ["linus"] = new("Linus Torvalds", "Kernel maintainer", 1991),
    };

    private readonly Signal<int> _requestCount = new(0);

    /// <summary>
    /// How many times the network was actually hit. Requests that were deduplicated, and reads
    /// served from cache, never increment it — which is the point of the demo.
    /// </summary>
    public IReadOnlySignal<int> RequestCount => _requestCount;

    /// <summary>
    /// While set, every call fails, so the resource's retries can be watched in the request
    /// count.
    /// </summary>
    public Signal<bool> IsBroken { get; } = new(false);

    public async Task<UserProfile> GetUserAsync(string id, CancellationToken cancellationToken)
    {
        _requestCount.Value++;

        await Task.Delay(TimeSpan.FromMilliseconds(700), cancellationToken);

        if (IsBroken.Value)
        {
            throw new InvalidOperationException("The user service is unavailable (503).");
        }

        return Profiles.TryGetValue(id, out var profile)
            ? profile
            : throw new KeyNotFoundException($"No user with id '{id}'.");
    }
}
