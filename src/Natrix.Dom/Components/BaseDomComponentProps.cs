using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

/// <summary>
/// Base for DOM component props.
/// </summary>
/// <remarks>
/// Props are stored sparsely: only the props that were set get an entry, so an instance costs a few
/// references per set prop instead of one field per declared prop. Each prop's setter passes its key
/// and the static lambdas that apply it on the client and on the server; rendering just walks the entries.
/// </remarks>
public abstract class BaseDomComponentProps<TElement>
    where TElement : Element
{
    private List<PropEntry>? _entries;

    /// <summary>
    /// Returns the signal stored under <paramref name="key"/>, or <c>null</c> if that prop was not set.
    /// </summary>
    private protected T? Get<T>(object key)
        where T : class
    {
        var index = IndexOf(key);
        return index >= 0 ? (T)_entries![index].Signal : null;
    }

    /// <summary>
    /// Stores <paramref name="signal"/> under <paramref name="key"/>, replacing any earlier value.
    /// </summary>
    /// <param name="key">Identifies the prop; a static object owned by the prop's declaring class.</param>
    /// <param name="signal">The prop's signal; <c>null</c> removes the prop.</param>
    /// <param name="clientEffect">Applies the signal's current value to the element. Only needed, and only
    /// passed, in the browser.</param>
    /// <param name="serverEffect">Binds the signal to the server-rendered element.</param>
    private protected void Set(
        object key,
        object? signal,
        Action<TElement, object>? clientEffect,
        Action<SsrElementNode, object> serverEffect)
    {
        var index = IndexOf(key);

        if (signal is null)
        {
            if (index >= 0)
            {
                _entries!.RemoveAt(index);
            }

            return;
        }

        var entry = new PropEntry(key, signal, clientEffect, serverEffect);
        if (index >= 0)
        {
            _entries![index] = entry;
        }
        else
        {
            (_entries ??= []).Add(entry);
        }
    }

    [SupportedOSPlatform("browser")]
    internal void RegisterClientEffects(Action<Action<TElement>> register)
    {
        if (_entries is null)
        {
            return;
        }

        foreach (var entry in _entries)
        {
            var clientEffect = entry.ClientEffect!;
            var signal = entry.Signal;
            register(el => clientEffect(el, signal));
        }
    }

    internal void RegisterServerEffects(SsrElementNode el)
    {
        if (_entries is null)
        {
            return;
        }

        foreach (var entry in _entries)
        {
            entry.ServerEffect(el, entry.Signal);
        }
    }

    private int IndexOf(object key)
    {
        if (_entries is not null)
        {
            for (var i = 0; i < _entries.Count; i++)
            {
                if (ReferenceEquals(_entries[i].Key, key))
                {
                    return i;
                }
            }
        }

        return -1;
    }

    private readonly struct PropEntry(
        object key,
        object signal,
        Action<TElement, object>? clientEffect,
        Action<SsrElementNode, object> serverEffect)
    {
        public readonly object Key = key;
        public readonly object Signal = signal;
        public readonly Action<TElement, object>? ClientEffect = clientEffect;
        public readonly Action<SsrElementNode, object> ServerEffect = serverEffect;
    }
}
