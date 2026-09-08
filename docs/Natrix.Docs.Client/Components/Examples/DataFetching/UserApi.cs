using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Natrix.Docs.Contracts;

namespace Natrix.Docs.Client.Components.Examples.DataFetching;

/// <summary>
/// Talks to the docs site's own user endpoints. The same class serves both hosts — the browser
/// resolves them against the page's origin, the SSR host against the request it is answering — so
/// the fetcher a component writes does not care which side it runs on.
/// </summary>
public sealed class UserApi(HttpClient httpClient, JsonSerializerOptions serializerOptions)
{
    private const string HealthyRoute = "api/users";
    private const string FailingRoute = "api/failing/users";

    // Pulled out of the application's own options rather than naming the context directly, so
    // there is one place that decides how this app's JSON is resolved. Going through JsonTypeInfo
    // is also what keeps the read AOT-safe: the JsonSerializerOptions overloads of
    // ReadFromJsonAsync cannot prove a resolver is present and are unsafe for trimming.
    private readonly JsonTypeInfo<UserProfile> _userProfile =
        (JsonTypeInfo<UserProfile>)serializerOptions.GetTypeInfo(typeof(UserProfile));

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

        return await response.Content.ReadFromJsonAsync(_userProfile, cancellationToken)
            ?? throw new InvalidOperationException($"The user service returned no body for '{id}'.");
    }
}
