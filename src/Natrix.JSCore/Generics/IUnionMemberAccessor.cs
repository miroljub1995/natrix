namespace Natrix.JSCore.Generics;

/// <summary>
/// The kind of a JavaScript value, as reported in the <c>type</c> field of the box that
/// <c>getPropertyAsUnion</c> wraps union values in.
/// </summary>
public enum JSValueKind
{
    Boolean = 1,
    Number = 2,
    BigInt = 3,
    String = 4,
    Symbol = 5,
    Function = 6,
    Object = 7,
    ManagedObject = 8,
}

/// <summary>
/// A property accessor that can also be used for a member of a <c>Union</c>: on top of reading and
/// writing the value, it tells whether a JavaScript value of a given kind can be read as this member.
/// </summary>
public interface IUnionMemberAccessor<T> : IPropertyAccessor<T>
{
    static abstract bool CanRead(JSValueKind kind);
}
