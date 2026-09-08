using System.Runtime.CompilerServices;
using Natrix.Core.Features;

namespace Natrix.Swr;

public static partial class SwrResource
{
    /// <summary>
    /// Binds a component to a tuple key and keeps it there, refetching whenever it changes. The
    /// tuple's element types flow through to the fetcher, which reads its parameters back as what
    /// they were:
    /// <code>
    /// var user = SwrResource.Use(
    ///     () => ("user", Props.UserId.Value),
    ///     async (key, ct) => await api.GetUserAsync(key.Item2, ct));
    /// </code>
    /// </summary>
    /// <remarks>
    /// The <see cref="ITuple"/> constraint is what keeps this to one method instead of one per
    /// arity, and it is also why the arity is not capped at seven: a longer tuple nests its
    /// remainder in a rest tuple, and the shape is flattened rather than matched against a fixed
    /// list of overloads. <see cref="SwrKey"/> is not a tuple, so the overloads taking one are
    /// never in the running here.
    /// </remarks>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<TKey, TData>(
        Func<TKey> key,
        Func<TKey, CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
        where TKey : struct, ITuple
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        EnsureKeySegmentContracts<TKey>();

        return Use(
            () => SwrKey.FromTuple(key()),
            (k, token) => fetcher(k.Tuple<TKey>(), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a tuple key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;(string, int), User&gt;(...)</c>. That is also why the two forms are
    /// separate methods rather than one taking a nullable: inference has nothing to match a plain
    /// tuple literal against in <c>TKey?</c>, so the unpaused call would have to name its
    /// arguments too.
    /// </summary>
    /// <inheritdoc cref="Use{TKey, TData}(Func{TKey}, Func{TKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<TKey, TData>(
        Func<TKey?> key,
        Func<TKey, CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
        where TKey : struct, ITuple
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        EnsureKeySegmentContracts<TKey>();

        return Use(
            () => key() is { } tuple ? SwrKey.FromTuple(tuple) : SwrKey.None,
            (k, token) => fetcher(k.Tuple<TKey>(), token),
            configure);
    }

    /// <inheritdoc cref="Use{TKey, TData}(Func{TKey}, Func{TKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<TKey, TData>(
        Func<TKey> key,
        Func<TKey, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
        where TKey : struct, ITuple
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{TKey, TData}(Func{TKey?}, Func{TKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<TKey, TData>(
        Func<TKey?> key,
        Func<TKey, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
        where TKey : struct, ITuple
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <summary>
    /// Resolves the contract every element of the key encodes under, before anything is built.
    /// </summary>
    /// <remarks>
    /// Redundant for a key that binds straight away, which reaches the encoder inside <c>Use</c>
    /// regardless. It earns its place on the key that starts paused: that one has no segments to
    /// encode yet, so without this it carries the problem until something unpauses it and then
    /// reports it against whatever wrote that signal, rather than against the component holding
    /// the key.
    /// </remarks>
    private static void EnsureKeySegmentContracts<TKey>()
        where TKey : struct, ITuple
    {
        var feature = AppFeatures.Features.GetRequired<SwrFeature>();

        foreach (var type in SwrKeyTupleShape<TKey>.ElementTypes)
        {
            feature.EnsureKeySegmentContract(type);
        }
    }
}
