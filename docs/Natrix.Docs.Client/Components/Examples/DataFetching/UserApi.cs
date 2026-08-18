using System.Net.Http.Json;
using Natrix.Docs.Contracts;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

/// <summary>
/// Talks to the docs site's own user endpoints. The same class serves both hosts — the browser
/// resolves them against the page's origin, the SSR host against the request it is answering — so
/// the fetcher a component writes does not care which side it runs on.
/// </summary>
public sealed class UserApi(HttpClient httpClient)
{
    private const string HealthyRoute = "api/users";
    private const string FailingRoute = "api/failing/users";

    public Task<UserProfile> GetUserAsync(string id, CancellationToken cancellationToken) =>
        GetAsync(HealthyRoute, id, cancellationToken);

    /// <summary>
    /// Reads the same user from an endpoint that always fails, so the demo can show what a
    /// resource does with an unavailable service without the API having to hold a mode of its own.
    /// </summary>
    public Task<UserProfile> GetUserFromFailingEndpointAsync(string id, CancellationToken cancellationToken) =>
        GetAsync(FailingRoute, id, cancellationToken);

    private async Task<UserProfile> GetAsync(string route, string id, CancellationToken cancellationToken)
    {
        using var response = await httpClient.GetAsync(
            $"{route}/{Uri.EscapeDataString(id)}", cancellationToken);

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
