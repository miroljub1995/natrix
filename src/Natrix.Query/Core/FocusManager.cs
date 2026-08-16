namespace Natrix.Query;

/// <summary>
/// Tracks whether the application is in the foreground, and tells the client when that
/// changes so focused-again can trigger refetches. The counterpart of TanStack Query's
/// <c>focusManager</c>.
/// </summary>
/// <remarks>
/// Platform-neutral on purpose: it knows nothing about a document or a window. A host that
/// has one installs it through <see cref="SetEventListener"/>, which is also the seam tests
/// use to drive focus by hand.
/// </remarks>
public class FocusManager
{
    /// <summary>The instance a <see cref="QueryClient"/> uses unless it is given another one.</summary>
    public static FocusManager Default { get; } = new();

    private readonly List<Action<bool>> _listeners = [];
    private Func<Action<bool?>, IDisposable>? _setup;
    private IDisposable? _cleanup;
    private bool? _focused;

    /// <summary>
    /// Whether the app is focused. Unknown counts as focused, so a host that never reports
    /// focus behaves like an always-visible app rather than a permanently backgrounded one.
    /// </summary>
    public bool IsFocused => _focused ?? true;

    /// <summary>
    /// Installs the source of focus changes, replacing any previous one. The setup function
    /// receives the callback to invoke on every change and returns the subscription to
    /// dispose when the source is replaced.
    /// </summary>
    public void SetEventListener(Func<Action<bool?>, IDisposable>? setup)
    {
        _cleanup?.Dispose();
        _cleanup = null;
        _setup = setup;

        if (setup is not null)
        {
            _cleanup = setup(SetFocused);
        }
    }

    /// <summary>
    /// Reports the current focus state. <c>null</c> hands the decision back to the default.
    /// Notifies listeners only when the value actually changes.
    /// </summary>
    public void SetFocused(bool? focused)
    {
        var changed = _focused != focused;
        if (!changed)
        {
            return;
        }

        _focused = focused;
        OnFocus();
    }

    /// <summary>Notifies every listener of the current focus state.</summary>
    public void OnFocus()
    {
        var isFocused = IsFocused;
        foreach (var listener in _listeners.ToArray())
        {
            listener(isFocused);
        }
    }

    /// <summary>Subscribes to focus changes; dispose to unsubscribe.</summary>
    public IDisposable Subscribe(Action<bool> listener)
    {
        ArgumentNullException.ThrowIfNull(listener);
        _listeners.Add(listener);
        return new Subscription(this, listener);
    }

    private sealed class Subscription(FocusManager manager, Action<bool> listener) : IDisposable
    {
        public void Dispose() => manager._listeners.Remove(listener);
    }
}
