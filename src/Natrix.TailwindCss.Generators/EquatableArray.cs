using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Natrix.TailwindCss.Generators;

/// <summary>
/// An <see cref="ImmutableArray{T}"/> with structural equality.
/// </summary>
/// <remarks>
/// Incremental generator pipelines compare each step's output to decide whether
/// downstream steps can be skipped. <see cref="ImmutableArray{T}"/> compares by
/// the identity of its backing array, so two arrays with identical contents come
/// out unequal and every compilation re-runs the expensive step. Anything that
/// leaves a <c>Collect()</c> has to be wrapped in this before it reaches the rest
/// of the pipeline.
/// </remarks>
internal readonly struct EquatableArray<T> : IEquatable<EquatableArray<T>>, IEnumerable<T>
    where T : IEquatable<T>
{
    private readonly ImmutableArray<T> _array;

    public EquatableArray(ImmutableArray<T> array) => _array = array;

    public int Length => _array.IsDefault ? 0 : _array.Length;

    public T this[int index] => _array[index];

    public ImmutableArray<T> AsImmutableArray() => _array.IsDefault ? ImmutableArray<T>.Empty : _array;

    public bool Equals(EquatableArray<T> other)
    {
        if (_array.IsDefault || other._array.IsDefault)
            return _array.IsDefault && other._array.IsDefault;

        if (_array.Length != other._array.Length)
            return false;

        for (var i = 0; i < _array.Length; i++)
        {
            if (!_array[i].Equals(other._array[i]))
                return false;
        }

        return true;
    }

    public override bool Equals(object? obj) => obj is EquatableArray<T> other && Equals(other);

    public override int GetHashCode()
    {
        // FNV-1a. Hand-rolled because System.HashCode is not in netstandard2.0
        // and pulling in Microsoft.Bcl.HashCode would mean shipping another
        // assembly next to the analyzer.
        unchecked
        {
            var hash = (int)2166136261;
            foreach (var item in AsImmutableArray())
                hash = (hash ^ (item?.GetHashCode() ?? 0)) * 16777619;
            return hash;
        }
    }

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)AsImmutableArray()).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public static bool operator ==(EquatableArray<T> left, EquatableArray<T> right) => left.Equals(right);

    public static bool operator !=(EquatableArray<T> left, EquatableArray<T> right) => !left.Equals(right);
}
