namespace Natrix.Swr;

/// <summary>
/// One element of a <see cref="SwrKey"/>: a value, and the type its contract is looked up under.
///
/// The type is carried rather than taken from <c>Value.GetType()</c> because the two differ where
/// it matters — a <c>null</c> value has no runtime type at all, and a value held as an interface
/// or a base class should encode under the contract the caller declared, not the one it happens
/// to be.
/// </summary>
public readonly struct SwrKeySegment : IEquatable<SwrKeySegment>
{
    /// <summary>
    /// Builds a segment from a statically known type, which is how the typed <c>Use</c> overloads
    /// produce theirs — the type parameter is the declared type, with no reflection involved.
    /// </summary>
    public static SwrKeySegment Of<TValue>(TValue value) => new(value, typeof(TValue));

    public SwrKeySegment(object? value, Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        Value = value;
        Type = type;
    }

    public object? Value { get; }

    /// <summary>
    /// The type <see cref="Value"/> is serialized under when the key is encoded.
    /// </summary>
    public Type Type { get; }

    /// <summary>
    /// So that a key of plain strings can still be written as <c>["user", id]</c>.
    /// </summary>
    public static implicit operator SwrKeySegment(string? value) => new(value, typeof(string));

    public bool Equals(SwrKeySegment other) => Type == other.Type && Equals(Value, other.Value);

    public override bool Equals(object? obj) => obj is SwrKeySegment other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(Type, Value);

    public static bool operator ==(SwrKeySegment left, SwrKeySegment right) => left.Equals(right);

    public static bool operator !=(SwrKeySegment left, SwrKeySegment right) => !left.Equals(right);

    public override string ToString() => Value?.ToString() ?? "null";
}
