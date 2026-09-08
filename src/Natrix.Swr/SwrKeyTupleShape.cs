using System.Runtime.CompilerServices;

namespace Natrix.Swr;

/// <summary>
/// The declared element types of a tuple key, worked out once per closed type.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="ITuple"/> hands back values, and a value is not enough: a <c>null</c> element has no
/// runtime type at all, and one held as a base type would encode under whatever it happens to be
/// rather than what the call declared. The closed type knows both, so that is where this reads
/// them from — statically reachable through <c>typeof(TKey)</c>, resolved in a static constructor,
/// and never touched again for that type.
/// </para>
/// <para>
/// Tuples past seven elements nest: <c>(1, …, 8)</c> is a <c>ValueTuple</c> of seven plus a rest
/// tuple holding the remainder, so the generic arguments have to be walked to line up with the
/// flat positions <see cref="ITuple"/> reports. Doing that walk is also what makes arity here
/// unbounded, where writing an overload per arity never could be.
/// </para>
/// </remarks>
internal static class SwrKeyTupleShape<TKey>
    where TKey : struct, ITuple
{
    internal static Type[] ElementTypes { get; } = Flatten(typeof(TKey));

    private static Type[] Flatten(Type tuple)
    {
        var elements = new List<Type>();

        while (true)
        {
            var arguments = tuple.GetGenericArguments();

            // Eight arguments means the last is the rest tuple rather than an element of its own.
            if (arguments.Length < 8)
            {
                elements.AddRange(arguments);
                return [.. elements];
            }

            elements.AddRange(arguments[..7]);
            tuple = arguments[7];
        }
    }
}
