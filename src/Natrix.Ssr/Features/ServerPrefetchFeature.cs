using System.Collections.Concurrent;
using Natrix.Ssr.Abstractions.Features;

namespace Natrix.Ssr.Features;

/// <summary>
/// Default <see cref="IServerPrefetchFeature"/> implementation. Callbacks start the moment they
/// are registered and run concurrently; <see cref="WaitForCompletionAsync"/> waits for all of
/// them, and for whatever they register in turn.
/// </summary>
/// <remarks>
/// Only usable inside <see cref="SsrEventLoop"/>. A callback started outside it would have its
/// continuations resume on thread-pool threads while the render is still building the tree,
/// which the reactive layer is not built to survive, so <see cref="Register"/> refuses rather
/// than lets that happen.
/// </remarks>
/// <param name="cancellationToken">
/// The request's token, typically <c>HttpContext.RequestAborted</c>. Handed to every callback,
/// and what stops the drain waiting once the request is gone.
/// </param>
public sealed class ServerPrefetchFeature(CancellationToken cancellationToken = default) : IServerPrefetchFeature
{
    // Concurrent although every access is on the loop, so that the misuse the Register check
    // cannot see — a registration from a Task.Run body, which has no context — corrupts nothing.
    private readonly ConcurrentQueue<Task> _inFlight = new();

    // Only ever touched on the loop, which is what makes a plain field enough.
    private bool _drained;

    public void Register(Func<CancellationToken, Task> callback)
    {
        ArgumentNullException.ThrowIfNull(callback);

        if (SynchronizationContext.Current is not SerialSynchronizationContext)
        {
            throw new InvalidOperationException(
                $"{nameof(ServerPrefetchFeature)} can only register from inside {nameof(SsrEventLoop)}. "
                + $"Run the request handler through {nameof(SsrEventLoop)}.{nameof(SsrEventLoop.RunAsync)}, "
                + "mount and drain included, so that prefetches resume one at a time and never alongside "
                + "the render.");
        }

        if (_drained)
        {
            throw new InvalidOperationException(
                $"A prefetch was registered after {nameof(WaitForCompletionAsync)} completed; nothing is "
                + "left to wait for it, so it would outlive the response.");
        }

        _inFlight.Enqueue(Start(callback));
    }

    public async Task WaitForCompletionAsync()
    {
        List<Exception>? errors = null;

        // Each await lets the loop run continuations, some of which register more callbacks;
        // those land in the queue before this continuation resumes, so the loop sees them.
        while (_inFlight.TryDequeue(out var task))
        {
            try
            {
                await task.WaitAsync(cancellationToken);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                _drained = true;
                throw;
            }
            catch (Exception exception)
            {
                errors ??= [];
                errors.Add(exception);
            }
        }

        _drained = true;

        if (errors is { Count: > 0 })
        {
            throw new AggregateException(errors);
        }
    }

    /// <summary>
    /// A callback that throws before its first await would otherwise throw out of the
    /// <c>Setup</c> that registered it. It is a prefetch failure like any other, so it fails the
    /// drain like any other.
    /// </summary>
    private Task Start(Func<CancellationToken, Task> callback)
    {
        try
        {
            return callback(cancellationToken) ?? Task.CompletedTask;
        }
        catch (Exception exception)
        {
            return Task.FromException(exception);
        }
    }
}
