namespace Natrix.Signals;

/// <summary>
/// Suppresses dependency tracking for the lifetime of the scope, so signal reads
/// register no dependency on whichever effect happens to be running.
/// </summary>
public readonly struct UntrackedScope : IDisposable
{
    private readonly ISignalConsumer? _previous;

    public UntrackedScope()
    {
        _previous = ConsumerContext.Active;
        ConsumerContext.Active = null;
    }

    public void Dispose()
    {
        ConsumerContext.Active = _previous;
    }
}
