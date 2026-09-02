using System.Runtime.CompilerServices;

namespace Natrix.Core.Features;

/// <summary>
/// Represents a typed collection of HTTP-style features, modeled after
/// <c>Microsoft.AspNetCore.Http.Features.IFeatureCollection</c>.
/// </summary>
public interface IFeatureCollection : IEnumerable<KeyValuePair<Type, object>>
{
    bool IsReadOnly { get; }

    object? this[Type key] { get; set; }

    TFeature? Get<TFeature>();

    void Set<TFeature>(TFeature? instance);

    /// <summary>
    /// <see cref="Get{TFeature}"/> for a feature the caller cannot do without, which is most of
    /// them: a component that resolves one is going to dereference it on the next line, and
    /// "object reference not set" says nothing about which feature the application forgot to
    /// register.
    /// </summary>
    /// <param name="caller">
    /// Filled in by the compiler. It names the member that needed the feature, which is more use
    /// than the stack when the resolution happens in a shared helper.
    /// </param>
    /// <exception cref="InvalidOperationException">Nothing is registered for the feature.</exception>
    /// <remarks>
    /// Being a default implementation, it is reached through the interface — a variable typed as
    /// a concrete collection has to be cast, or go through <see cref="Get{TFeature}"/> as before.
    /// </remarks>
    TFeature GetRequired<TFeature>([CallerMemberName] string? caller = null) =>
        Get<TFeature>()
        ?? throw new InvalidOperationException(
            $"{caller} needs the {typeof(TFeature).Name} feature, which is not registered.");
}
