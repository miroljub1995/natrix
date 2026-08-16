using System.Collections;

namespace Natrix.Query;

/// <summary>
/// Decides what the cache stores when new data arrives — TanStack Query's <c>replaceData</c>.
/// </summary>
/// <remarks>
/// Structural sharing exists so that a refetch returning an identical payload does not hand
/// consumers a new reference. Under signals that matters more than it does under a virtual
/// DOM: a new reference wakes every effect reading <c>Data</c>, an old one wakes none.
/// <para>
/// TanStack Query rebuilds a partially shared tree (<c>replaceEqualDeep</c>), which needs
/// runtime reflection over arbitrary object graphs and is therefore off the table for a
/// trimmed, AOT-compiled assembly. This port keeps the previous reference when the incoming
/// data is deep-equal to it and takes the new one otherwise; supply
/// <see cref="ResolvedQueryOptions.StructuralSharingFn"/> for finer control over a specific
/// shape.
/// </para>
/// </remarks>
internal static class DataReplacer
{
    public static object? Replace(object? previous, object? next, ResolvedQueryOptions options)
    {
        if (options.StructuralSharingFn is not null)
        {
            return options.StructuralSharingFn(previous, next);
        }

        if (!options.StructuralSharing)
        {
            return next;
        }

        return DeepEqual(previous, next) ? previous : next;
    }

    /// <summary>
    /// Value equality that looks inside sequences and string-keyed dictionaries, and defers to
    /// <see cref="object.Equals(object?)"/> for everything else — which is exactly right for
    /// records, tuples and primitives.
    /// </summary>
    public static bool DeepEqual(object? a, object? b)
    {
        if (ReferenceEquals(a, b))
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        if (a is string || b is string)
        {
            return a.Equals(b);
        }

        if (a is IDictionary dictionaryA && b is IDictionary dictionaryB)
        {
            if (dictionaryA.Count != dictionaryB.Count)
            {
                return false;
            }

            foreach (DictionaryEntry entry in dictionaryA)
            {
                if (!dictionaryB.Contains(entry.Key) || !DeepEqual(entry.Value, dictionaryB[entry.Key]))
                {
                    return false;
                }
            }

            return true;
        }

        if (a is IEnumerable sequenceA && b is IEnumerable sequenceB)
        {
            var enumeratorA = sequenceA.GetEnumerator();
            var enumeratorB = sequenceB.GetEnumerator();
            try
            {
                while (true)
                {
                    var hasA = enumeratorA.MoveNext();
                    var hasB = enumeratorB.MoveNext();

                    if (hasA != hasB)
                    {
                        return false;
                    }

                    if (!hasA)
                    {
                        return true;
                    }

                    if (!DeepEqual(enumeratorA.Current, enumeratorB.Current))
                    {
                        return false;
                    }
                }
            }
            finally
            {
                (enumeratorA as IDisposable)?.Dispose();
                (enumeratorB as IDisposable)?.Dispose();
            }
        }

        return a.Equals(b);
    }
}
