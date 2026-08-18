using System.Net.Http.Json;
using Natrix.Docs.Contracts;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

/// <summary>
/// Talks to the docs site's own user endpoint. The same class serves both hosts — the browser
/// resolves the endpoint against the page's origin, the SSR host against the request it is
/// answering — so the fetcher a component writes does not care which side it runs on.
/// </summary>
public sealed class UserApi(HttpClient httpClient)
{
    private readonly Signal<int> _requestCount = new(0);

    /// <summary>
    /// Requests the <em>browser</em> made. Server-side prefetching is deliberately not counted:
    /// the point the demo is making is that a freshly loaded page has fetched nothing of its own,
    /// and a counter that started at whatever the server did would also disagree with the
    /// server-rendered markup during hydration.
    /// </summary>
    public IReadOnlySignal<int> RequestCount => _requestCount;

    /// <summary>
    /// While set, requests ask the endpoint to fail, so the resource's retry behaviour is visible.
    /// </summary>
    public Signal<bool> IsBroken { get; } = new(false);

    public async Task<UserProfile> GetUserAsync(string id, CancellationToken cancellationToken)
    {
        if (OperatingSystem.IsBrowser())
        {
            _requestCount.Value++;
        }

        var url = $"api/users/{Uri.EscapeDataString(id)}{(IsBroken.Value ? "?fail=1" : string.Empty)}";

        using var response = await httpClient.GetAsync(url, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(
                $"The user service is unavailable ({(int)response.StatusCode}).");
        }

        return await response.Content.ReadFromJsonAsync(
                DocsJsonContext.Default.UserProfile, cancellationToken)
            ?? throw new InvalidOperationException($"The user service returned no body for '{id}'.");
    }
}
