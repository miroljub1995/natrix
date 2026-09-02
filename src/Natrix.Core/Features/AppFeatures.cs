using System.Runtime.CompilerServices;

namespace Natrix.Core.Features;

/// <summary>
/// Ambient access to the currently mounting component's <see cref="IFeatureCollection"/>.
///
/// Backed by <see cref="ThreadLocal{T}"/>: per-thread state, no propagation across
/// <c>await</c>. The framework sets it synchronously around each component's
/// <c>Mount</c> call and resets it to <c>null</c> when the outermost <c>Mount</c>
/// returns. It is only valid to read inside <c>Setup</c> (or other code paths the
/// framework explicitly re-establishes it for, such as delayed children mounted
/// by <see cref="Components.If"/> / <see cref="Components.ForEach{TElement,TKey}"/>).
/// </summary>
public static class AppFeatures
{
    private static readonly ThreadLocal<IFeatureCollection?> _current = new();

    public static IFeatureCollection? Current
    {
        get => _current.Value;
        set => _current.Value = value;
    }

    /// <summary>
    /// Same as <see cref="Current"/> but throws when there is no active features
    /// collection. Use this from inside component <c>Setup</c> code where a
    /// features collection must be available.
    /// </summary>
    /// <remarks>
    /// A property cannot be told who read it, so this reports itself rather than the caller.
    /// <see cref="GetRequiredCurrent"/> is the same thing with that name in the message.
    /// </remarks>
    public static IFeatureCollection Features =>
        Current ?? throw new InvalidOperationException(
            "AppFeatures.Features accessed outside of a component Mount. " +
            "It is only valid inside Setup (or code paths the framework re-establishes it for).");

    /// <summary>
    /// <see cref="Features"/>, blaming the member that asked. Prefer it wherever the caller is a
    /// named entry point of its own — the message is then about that call rather than about a
    /// framework property the reader has to work back from.
    /// </summary>
    /// <param name="caller">
    /// Filled in by the compiler. Pass it explicitly from a shared helper, to name the entry point
    /// the user actually called rather than the helper.
    /// </param>
    /// <exception cref="InvalidOperationException">
    /// There is no component being set up. <see cref="Current"/> is only non-null inside
    /// <c>Setup</c>, and code paths the framework re-establishes it for.
    /// </exception>
    public static IFeatureCollection GetRequiredCurrent([CallerMemberName] string? caller = null) =>
        Current ?? throw new InvalidOperationException(
            $"{caller} can only be called while a component is being set up: it needs that "
            + "component's features, and outside Setup there are none.");
}
