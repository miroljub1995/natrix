using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

/// <summary>
/// Base for DOM component props.
/// </summary>
/// <remarks>
/// Props are stored sparsely: only the props that were set get an entry, so an instance costs two
/// references per set prop instead of one field per declared prop. Each prop is described by a
/// <see cref="PropDescriptor{TValue}"/> holding the lambdas that apply it on the client and on the server;
/// an entry pairs that descriptor with the signal, and rendering just walks the entries.
/// <para>
/// A prop's descriptor lives in a static field of the class that declares the prop, and is created by
/// its <c>init</c> accessor the first time the prop is set. Keeping the lambdas in the accessor, rather
/// than in a static initializer, lets the trimmer drop a prop the app never sets, together with the
/// element members its lambdas use.
/// </para>
/// </remarks>
public abstract class BaseDomComponentProps<TElement>
    where TElement : Element
{
    private List<PropEntry>? _entries;

    /// <summary>
    /// Returns the signal stored for <paramref name="prop"/>, or <c>null</c> if that prop was not set.
    /// A <c>null</c> descriptor means the prop was never set on any instance.
    /// </summary>
    private protected IReadOnlySignal<TValue>? Get<TValue>(PropDescriptor<TValue>? prop)
    {
        if (prop is null)
        {
            return null;
        }

        var index = IndexOf(prop);
        return index >= 0 ? (IReadOnlySignal<TValue>)_entries![index].Signal : null;
    }

    /// <summary>
    /// Stores <paramref name="signal"/> for the prop whose descriptor lives in <paramref name="prop"/>,
    /// replacing any earlier value; <c>null</c> removes the prop.
    /// </summary>
    /// <param name="prop">The prop's static descriptor field; created with <paramref name="create"/> on
    /// first use. Creation is thread-safe, so every instance agrees on one descriptor.</param>
    /// <param name="signal">The prop's signal.</param>
    /// <param name="create">Creates the descriptor.</param>
    private protected void Set<TValue>(
        ref PropDescriptor<TValue>? prop,
        IReadOnlySignal<TValue>? signal,
        Func<PropDescriptor<TValue>> create)
    {
        if (signal is null && prop is null)
        {
            return;
        }

        var descriptor = LazyInitializer.EnsureInitialized(ref prop, create);
        var index = IndexOf(descriptor);

        if (signal is null)
        {
            if (index >= 0)
            {
                _entries!.RemoveAt(index);
            }

            return;
        }

        var entry = new PropEntry(descriptor, signal);
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
            var prop = entry.Prop;
            var signal = entry.Signal;
            register(el => prop.ApplyClient(el, signal));
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
            entry.Prop.ApplyServer(el, entry.Signal);
        }
    }

    private int IndexOf(PropDescriptor prop)
    {
        if (_entries is not null)
        {
            for (var i = 0; i < _entries.Count; i++)
            {
                if (ReferenceEquals(_entries[i].Prop, prop))
                {
                    return i;
                }
            }
        }

        return -1;
    }

    private readonly struct PropEntry(PropDescriptor prop, object signal)
    {
        public readonly PropDescriptor Prop = prop;
        public readonly object Signal = signal;
    }

    /// <summary>
    /// Identifies a prop and applies its signal to an element; untyped so entries of any value type
    /// share one list.
    /// </summary>
    private protected abstract class PropDescriptor
    {
        [SupportedOSPlatform("browser")]
        public abstract void ApplyClient(TElement el, object signal);

        public abstract void ApplyServer(SsrElementNode el, object signal);
    }

    /// <summary>
    /// Describes a prop whose signal carries <typeparamref name="TValue"/>. One per prop, kept in a static
    /// field of the props class that declares it.
    /// </summary>
    /// <param name="client">Applies the signal's current value to the element. Only runs in the browser;
    /// its body guards browser-only calls with <see cref="OperatingSystem.IsBrowser"/>.</param>
    /// <param name="server">Binds the signal to the server-rendered element.</param>
    private protected sealed class PropDescriptor<TValue>(
        Action<TElement, IReadOnlySignal<TValue>> client,
        Action<SsrElementNode, IReadOnlySignal<TValue>> server) : PropDescriptor
    {
        [SupportedOSPlatform("browser")]
        public override void ApplyClient(TElement el, object signal) =>
            client(el, (IReadOnlySignal<TValue>)signal);

        public override void ApplyServer(SsrElementNode el, object signal) =>
            server(el, (IReadOnlySignal<TValue>)signal);
    }
}
