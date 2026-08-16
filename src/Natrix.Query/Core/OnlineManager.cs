namespace Natrix.Query;

/// <summary>
/// Tracks connectivity, which is what makes <see cref="NetworkMode.Online"/> queries pause
/// instead of fail while offline and resume when the connection returns. The counterpart of
/// TanStack Query's <c>onlineManager</c>.
/// </summary>
/// <remarks>
/// Platform-neutral: a host that can observe connectivity installs it through
/// <see cref="SetEventListener"/>, which is also how tests take the network offline.
/// </remarks>
public class OnlineManager
{
    /// <summary>The instance a <see cref="QueryClient"/> uses unless it is given another one.</summary>
    public static OnlineManager Default { get; } = new();

    private readonly List<Action<bool>> _listeners = [];
    private IDisposable? _cleanup;
    private bool? _online;

    /// <summary>Whether the app is online. Unknown counts as online.</summary>
    public bool IsOnline => _online ?? true;

    /// <summary>
    /// Installs the source of connectivity changes, replacing any previous one. The setup
    /// function receives the callback to invoke on every change and returns the subscription
    /// to dispose when the source is replaced.
    /// </summary>
    public void SetEventListener(Func<Action<bool?>, IDisposable>? setup)
    {
        _cleanup?.Dispose();
        _cleanup = null;

        if (setup is not null)
        {
            _cleanup = setup(SetOnline);
        }
    }

    /// <summary>
    /// Reports the current connectivity. <c>null</c> hands the decision back to the default.
    /// Notifies listeners only when the value actually changes.
    /// </summary>
    public void SetOnline(bool? online)
    {
        var changed = _online != online;
        if (!changed)
        {
            return;
        }

        _online = online;

        var isOnline = IsOnline;
        foreach (var listener in _listeners.ToArray())
        {
            listener(isOnline);
        }
    }

    /// <summary>Subscribes to connectivity changes; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<bool> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    private sealed class Subscription(OnlineManager manager, Action<bool> listener) : IDisposable
    {
        public void Dispose() => manager._listeners.Remove(listener);
    }
}
