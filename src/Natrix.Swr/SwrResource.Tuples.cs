namespace Natrix.Swr;

// The typed half of the entry point: key factories that return a tuple, and fetchers that receive
// it back with its types intact. Documented on the other part of the class, since a partial type
// takes its doc comment from one part only.
//
// Every arity here is the same three lines: resolve each segment type's contract up front, build
// a SwrKey whose segments carry the type parameter they were declared with, and unpack it again
// for the fetcher. They are written out rather than generated because a tuple's arity cannot be
// abstracted over.
//
// Arity starts at two. A single segment is not a tuple, so its overload would take a bare
// Func<T> and sit directly under the untyped one - and a one-segment key is a bad key anyway,
// since it has nothing in it to tell one resource's ids apart from another's.
public static partial class SwrResource
{
    /// <summary>
    /// Binds a component to a 2-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, TData>(
        Func<(T1, T2)> key,
        Func<(T1, T2), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 2-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, TData>(
        Func<(T1, T2)?> key,
        Func<(T1, T2), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, TData}(Func{(T1, T2)}, Func{(T1, T2), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, TData>(
        Func<(T1, T2)> key,
        Func<(T1, T2), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, TData}(Func{(T1, T2)?}, Func{(T1, T2), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, TData>(
        Func<(T1, T2)?> key,
        Func<(T1, T2), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2>((T1, T2) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2));

    /// <summary>
    /// Binds a component to a 3-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, TData>(
        Func<(T1, T2, T3)> key,
        Func<(T1, T2, T3), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 3-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, TData>(
        Func<(T1, T2, T3)?> key,
        Func<(T1, T2, T3), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, TData}(Func{(T1, T2, T3)}, Func{(T1, T2, T3), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, TData>(
        Func<(T1, T2, T3)> key,
        Func<(T1, T2, T3), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, TData}(Func{(T1, T2, T3)?}, Func{(T1, T2, T3), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, TData>(
        Func<(T1, T2, T3)?> key,
        Func<(T1, T2, T3), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2, T3>((T1, T2, T3) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2), SwrKeySegment.Of(segments.Item3));

    /// <summary>
    /// Binds a component to a 4-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, TData>(
        Func<(T1, T2, T3, T4)> key,
        Func<(T1, T2, T3, T4), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 4-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, TData>(
        Func<(T1, T2, T3, T4)?> key,
        Func<(T1, T2, T3, T4), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, TData}(Func{(T1, T2, T3, T4)}, Func{(T1, T2, T3, T4), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, TData>(
        Func<(T1, T2, T3, T4)> key,
        Func<(T1, T2, T3, T4), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, TData}(Func{(T1, T2, T3, T4)?}, Func{(T1, T2, T3, T4), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, TData>(
        Func<(T1, T2, T3, T4)?> key,
        Func<(T1, T2, T3, T4), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2, T3, T4>((T1, T2, T3, T4) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2), SwrKeySegment.Of(segments.Item3), SwrKeySegment.Of(segments.Item4));

    /// <summary>
    /// Binds a component to a 5-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, TData>(
        Func<(T1, T2, T3, T4, T5)> key,
        Func<(T1, T2, T3, T4, T5), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 5-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, TData>(
        Func<(T1, T2, T3, T4, T5)?> key,
        Func<(T1, T2, T3, T4, T5), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, TData}(Func{(T1, T2, T3, T4, T5)}, Func{(T1, T2, T3, T4, T5), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, TData>(
        Func<(T1, T2, T3, T4, T5)> key,
        Func<(T1, T2, T3, T4, T5), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, TData}(Func{(T1, T2, T3, T4, T5)?}, Func{(T1, T2, T3, T4, T5), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, TData>(
        Func<(T1, T2, T3, T4, T5)?> key,
        Func<(T1, T2, T3, T4, T5), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2, T3, T4, T5>((T1, T2, T3, T4, T5) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2), SwrKeySegment.Of(segments.Item3), SwrKeySegment.Of(segments.Item4), SwrKeySegment.Of(segments.Item5));

    /// <summary>
    /// Binds a component to a 6-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, TData>(
        Func<(T1, T2, T3, T4, T5, T6)> key,
        Func<(T1, T2, T3, T4, T5, T6), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();
        feature.EnsureKeySegmentContract<T6>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4), k.Segment<T6>(5)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 6-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, TData>(
        Func<(T1, T2, T3, T4, T5, T6)?> key,
        Func<(T1, T2, T3, T4, T5, T6), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();
        feature.EnsureKeySegmentContract<T6>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4), k.Segment<T6>(5)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, T6, TData}(Func{(T1, T2, T3, T4, T5, T6)}, Func{(T1, T2, T3, T4, T5, T6), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, TData>(
        Func<(T1, T2, T3, T4, T5, T6)> key,
        Func<(T1, T2, T3, T4, T5, T6), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, T6, TData}(Func{(T1, T2, T3, T4, T5, T6)?}, Func{(T1, T2, T3, T4, T5, T6), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, TData>(
        Func<(T1, T2, T3, T4, T5, T6)?> key,
        Func<(T1, T2, T3, T4, T5, T6), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2, T3, T4, T5, T6>((T1, T2, T3, T4, T5, T6) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2), SwrKeySegment.Of(segments.Item3), SwrKeySegment.Of(segments.Item4), SwrKeySegment.Of(segments.Item5), SwrKeySegment.Of(segments.Item6));

    /// <summary>
    /// Binds a component to a 7-segment key and keeps it there, refetching whenever it changes.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, T7, TData>(
        Func<(T1, T2, T3, T4, T5, T6, T7)> key,
        Func<(T1, T2, T3, T4, T5, T6, T7), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();
        feature.EnsureKeySegmentContract<T6>();
        feature.EnsureKeySegmentContract<T7>();

        return Use(
            () => Key(key()),
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4), k.Segment<T6>(5), k.Segment<T7>(6)), token),
            configure);
    }

    /// <summary>
    /// Binds a component to a 7-segment key, or pauses while the factory returns <c>null</c>.
    ///
    /// A tuple has no absent value of its own, so <see cref="SwrKey.None"/> is spelled
    /// <c>null</c>:
    /// <code>
    /// () => userId.Value is { } id ? ("user", id) : null
    /// </code>
    /// A conditional like that has no natural type for the compiler to infer the arguments from,
    /// so name them: <c>Use&lt;string, int, User&gt;(...)</c>.
    /// </summary>
    /// <inheritdoc cref="Use{TData}(Func{SwrKey}, Func{SwrKey, CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, T7, TData>(
        Func<(T1, T2, T3, T4, T5, T6, T7)?> key,
        Func<(T1, T2, T3, T4, T5, T6, T7), CancellationToken, Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(key);
        ArgumentNullException.ThrowIfNull(fetcher);

        // Ahead of everything else, so a segment type nothing describes is reported against
        // the component that named it even when the key it names starts out paused.
        var (_, feature) = Resolve();
        feature.EnsureKeySegmentContract<T1>();
        feature.EnsureKeySegmentContract<T2>();
        feature.EnsureKeySegmentContract<T3>();
        feature.EnsureKeySegmentContract<T4>();
        feature.EnsureKeySegmentContract<T5>();
        feature.EnsureKeySegmentContract<T6>();
        feature.EnsureKeySegmentContract<T7>();

        return Use(
            () => key() is { } segments ? Key(segments) : SwrKey.None,
            (k, token) => fetcher((k.Segment<T1>(0), k.Segment<T2>(1), k.Segment<T3>(2), k.Segment<T4>(3), k.Segment<T5>(4), k.Segment<T6>(5), k.Segment<T7>(6)), token),
            configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, T6, T7, TData}(Func{(T1, T2, T3, T4, T5, T6, T7)}, Func{(T1, T2, T3, T4, T5, T6, T7), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, T7, TData>(
        Func<(T1, T2, T3, T4, T5, T6, T7)> key,
        Func<(T1, T2, T3, T4, T5, T6, T7), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    /// <inheritdoc cref="Use{T1, T2, T3, T4, T5, T6, T7, TData}(Func{(T1, T2, T3, T4, T5, T6, T7)?}, Func{(T1, T2, T3, T4, T5, T6, T7), CancellationToken, Task{TData}}, Func{SwrOptions, SwrOptions}?)"/>
    public static SwrResource<TData> Use<T1, T2, T3, T4, T5, T6, T7, TData>(
        Func<(T1, T2, T3, T4, T5, T6, T7)?> key,
        Func<(T1, T2, T3, T4, T5, T6, T7), Task<TData>> fetcher,
        Func<SwrOptions, SwrOptions>? configure = null)
    {
        ArgumentNullException.ThrowIfNull(fetcher);

        return Use(key, (k, _) => fetcher(k), configure);
    }

    private static SwrKey Key<T1, T2, T3, T4, T5, T6, T7>((T1, T2, T3, T4, T5, T6, T7) segments) =>
        new(SwrKeySegment.Of(segments.Item1), SwrKeySegment.Of(segments.Item2), SwrKeySegment.Of(segments.Item3), SwrKeySegment.Of(segments.Item4), SwrKeySegment.Of(segments.Item5), SwrKeySegment.Of(segments.Item6), SwrKeySegment.Of(segments.Item7));
}
