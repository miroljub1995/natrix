namespace Natrix.Docs.Contracts;

/// <summary>
/// The shape the user endpoint returns. Lives here rather than in either host so the client and
/// the server cannot drift apart, and so the SWR cache can be handed from one to the other.
/// </summary>
public sealed record UserProfile(string Name, string Role, int Followers);
