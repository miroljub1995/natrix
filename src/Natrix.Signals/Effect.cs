namespace Natrix.Signals;

public class Effect : IEffect
{
    private readonly IEffectScope _scope;
    private readonly Action<Action<Action>> _fn;
    private readonly List<Action> _cleanupFns = [];
    private readonly Dictionary<ISignalProducer, long> _producers = [];
    private byte _disposed;

    public Effect(Action<Action<Action>> fn)
    {
        _scope = EffectScopeContext.Active ?? throw new("Can not create effect outside of scope.");

        _fn = fn;

        _scope.AddEffect(this);
        RunFun();
    }

    public void Dispose()
    {
        if (Interlocked.Exchange(ref _disposed, 1) == 0)
        {
            UnsubscribeFromProducers();
            FlushCleanups();
            _scope.RemoveEffect(this);
        }
    }

    public void TrackProducer(ISignalProducer producer)
    {
        _producers.Add(producer, producer.GetVersion());
    }

    public void UntrackProducer(ISignalProducer producer)
    {
        _producers.Remove(producer);
    }

    public void ConsumeSignal()
    {
        if (_disposed != 0)
        {
            return;
        }

        if (!AnyProducerChanged())
        {
            return;
        }

        UnsubscribeFromProducers();
        FlushCleanups();
        RunFun();
    }

    private void RunFun()
    {
        // Every run happens in the scope that owns this effect, not only the first. A re-run is
        // triggered from wherever the signal was written - a click handler, a continuation -
        // and a scope created there would otherwise be parented to whatever happens to be
        // ambient, or to nothing, cutting it off from the tree that owns and roots it.
        var oldConsumer = ConsumerContext.Active;
        var oldScope = EffectScopeContext.Active;
        ConsumerContext.Active = this;
        EffectScopeContext.Active = _scope;
        try
        {
            _fn(_cleanupFns.Add);
        }
        finally
        {
            EffectScopeContext.Active = oldScope;
            ConsumerContext.Active = oldConsumer;
        }
    }

    private void UnsubscribeFromProducers()
    {
        while (_producers.Count > 0)
        {
            _producers.First().Key.Unsubscribe(this);
        }
    }

    private void FlushCleanups()
    {
        foreach (var cleanupFn in _cleanupFns)
        {
            cleanupFn();
        }

        _cleanupFns.Clear();
    }

    private bool AnyProducerChanged()
    {
        return _producers.Any(producer => producer.Value != producer.Key.GetVersion());
    }
}