namespace Natrix.Ssr.Abstractions.Features;

/// <summary>
/// SSR-only feature that lets components start asynchronous work during their <c>Setup</c> —
/// fetching the data they render — which the host waits for before it writes the response.
/// Modeled after Vue's <c>onServerPrefetch</c>.
/// </summary>
/// <remarks>
/// Prefetches start as they are registered and run concurrently: a page with five independent
/// fetches waits for the slowest, not for the sum. What makes that safe is the host's event
/// loop, which the whole request runs on and which runs continuations one at a time — a
/// callback is free to write signals after its awaits, and never runs alongside the render or
/// another callback's continuation. What a callback does <em>before</em> its first await runs
/// inside the <c>Setup</c> that registered it, so it must not write signals there.
/// </remarks>
public interface IServerPrefetchFeature
{
    /// <summary>
    /// Starts <paramref name="callback"/> and keeps its task for
    /// <see cref="WaitForCompletionAsync"/>. The token it receives is cancelled when the request
    /// is: a fetch for a response nobody is waiting for should stop.
    /// </summary>
    void Register(Func<CancellationToken, Task> callback);

    /// <summary>
    /// Completes when every registered callback has, including callbacks registered while it
    /// waits — a prefetch that moves a signal can mount a subtree that registers its own.
    /// Waits for all of them even when some fail, then throws an <see cref="AggregateException"/>
    /// carrying every failure. Throws <see cref="OperationCanceledException"/> once the request
    /// is cancelled rather than waiting for callbacks that ignore their token.
    /// </summary>
    Task WaitForCompletionAsync();
}
