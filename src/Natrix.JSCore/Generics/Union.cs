using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace Natrix.JSCore.Generics;

// A WebIDL union. Each member type T{n} comes with the accessor TAccessor{n} that marshals it, so
// using a union only keeps the marshalling code of the members it actually touches.

public class Union<T1, T2, TAccessor1, TAccessor2>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, TAccessor1, TAccessor2>>
    where T1 : notnull
    where T2 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, TAccessor1, TAccessor2> IJSObjectProxy<Union<T1, T2, TAccessor1, TAccessor2>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, TAccessor1, TAccessor2>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, TAccessor1, TAccessor2>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);
}

public class Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3> IJSObjectProxy<Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, TAccessor1, TAccessor2, TAccessor3>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4> IJSObjectProxy<Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, TAccessor1, TAccessor2, TAccessor3, TAccessor4>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5> IJSObjectProxy<Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where T26 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
    where TAccessor26 : IUnionMemberAccessor<T26>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26>(T26 value) =>
        new(UnionMarshaller.ToJS<T26, TAccessor26>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T26? value) =>
        UnionMarshaller.TryToManaged<T26, TAccessor26>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where T26 : notnull
    where T27 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
    where TAccessor26 : IUnionMemberAccessor<T26>
    where TAccessor27 : IUnionMemberAccessor<T27>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T26 value) =>
        new(UnionMarshaller.ToJS<T26, TAccessor26>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27>(T27 value) =>
        new(UnionMarshaller.ToJS<T27, TAccessor27>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T26? value) =>
        UnionMarshaller.TryToManaged<T26, TAccessor26>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T27? value) =>
        UnionMarshaller.TryToManaged<T27, TAccessor27>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where T26 : notnull
    where T27 : notnull
    where T28 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
    where TAccessor26 : IUnionMemberAccessor<T26>
    where TAccessor27 : IUnionMemberAccessor<T27>
    where TAccessor28 : IUnionMemberAccessor<T28>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T26 value) =>
        new(UnionMarshaller.ToJS<T26, TAccessor26>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T27 value) =>
        new(UnionMarshaller.ToJS<T27, TAccessor27>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28>(T28 value) =>
        new(UnionMarshaller.ToJS<T28, TAccessor28>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T26? value) =>
        UnionMarshaller.TryToManaged<T26, TAccessor26>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T27? value) =>
        UnionMarshaller.TryToManaged<T27, TAccessor27>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T28? value) =>
        UnionMarshaller.TryToManaged<T28, TAccessor28>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where T26 : notnull
    where T27 : notnull
    where T28 : notnull
    where T29 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
    where TAccessor26 : IUnionMemberAccessor<T26>
    where TAccessor27 : IUnionMemberAccessor<T27>
    where TAccessor28 : IUnionMemberAccessor<T28>
    where TAccessor29 : IUnionMemberAccessor<T29>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T26 value) =>
        new(UnionMarshaller.ToJS<T26, TAccessor26>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T27 value) =>
        new(UnionMarshaller.ToJS<T27, TAccessor27>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T28 value) =>
        new(UnionMarshaller.ToJS<T28, TAccessor28>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29>(T29 value) =>
        new(UnionMarshaller.ToJS<T29, TAccessor29>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T26? value) =>
        UnionMarshaller.TryToManaged<T26, TAccessor26>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T27? value) =>
        UnionMarshaller.TryToManaged<T27, TAccessor27>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T28? value) =>
        UnionMarshaller.TryToManaged<T28, TAccessor28>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T29? value) =>
        UnionMarshaller.TryToManaged<T29, TAccessor29>(JSObject, out value);
}

public class Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>
    : JSObjectProxy, IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>>
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
    where T5 : notnull
    where T6 : notnull
    where T7 : notnull
    where T8 : notnull
    where T9 : notnull
    where T10 : notnull
    where T11 : notnull
    where T12 : notnull
    where T13 : notnull
    where T14 : notnull
    where T15 : notnull
    where T16 : notnull
    where T17 : notnull
    where T18 : notnull
    where T19 : notnull
    where T20 : notnull
    where T21 : notnull
    where T22 : notnull
    where T23 : notnull
    where T24 : notnull
    where T25 : notnull
    where T26 : notnull
    where T27 : notnull
    where T28 : notnull
    where T29 : notnull
    where T30 : notnull
    where TAccessor1 : IUnionMemberAccessor<T1>
    where TAccessor2 : IUnionMemberAccessor<T2>
    where TAccessor3 : IUnionMemberAccessor<T3>
    where TAccessor4 : IUnionMemberAccessor<T4>
    where TAccessor5 : IUnionMemberAccessor<T5>
    where TAccessor6 : IUnionMemberAccessor<T6>
    where TAccessor7 : IUnionMemberAccessor<T7>
    where TAccessor8 : IUnionMemberAccessor<T8>
    where TAccessor9 : IUnionMemberAccessor<T9>
    where TAccessor10 : IUnionMemberAccessor<T10>
    where TAccessor11 : IUnionMemberAccessor<T11>
    where TAccessor12 : IUnionMemberAccessor<T12>
    where TAccessor13 : IUnionMemberAccessor<T13>
    where TAccessor14 : IUnionMemberAccessor<T14>
    where TAccessor15 : IUnionMemberAccessor<T15>
    where TAccessor16 : IUnionMemberAccessor<T16>
    where TAccessor17 : IUnionMemberAccessor<T17>
    where TAccessor18 : IUnionMemberAccessor<T18>
    where TAccessor19 : IUnionMemberAccessor<T19>
    where TAccessor20 : IUnionMemberAccessor<T20>
    where TAccessor21 : IUnionMemberAccessor<T21>
    where TAccessor22 : IUnionMemberAccessor<T22>
    where TAccessor23 : IUnionMemberAccessor<T23>
    where TAccessor24 : IUnionMemberAccessor<T24>
    where TAccessor25 : IUnionMemberAccessor<T25>
    where TAccessor26 : IUnionMemberAccessor<T26>
    where TAccessor27 : IUnionMemberAccessor<T27>
    where TAccessor28 : IUnionMemberAccessor<T28>
    where TAccessor29 : IUnionMemberAccessor<T29>
    where TAccessor30 : IUnionMemberAccessor<T30>
{
    [SupportedOSPlatform("browser")]
    public Union(JSObject obj) : base(obj)
    {
    }

    [SupportedOSPlatform("browser")]
    static Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30> IJSObjectProxy<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>>.Create(JSObject obj) => new(obj);

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T1 value) =>
        new(UnionMarshaller.ToJS<T1, TAccessor1>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T2 value) =>
        new(UnionMarshaller.ToJS<T2, TAccessor2>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T3 value) =>
        new(UnionMarshaller.ToJS<T3, TAccessor3>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T4 value) =>
        new(UnionMarshaller.ToJS<T4, TAccessor4>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T5 value) =>
        new(UnionMarshaller.ToJS<T5, TAccessor5>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T6 value) =>
        new(UnionMarshaller.ToJS<T6, TAccessor6>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T7 value) =>
        new(UnionMarshaller.ToJS<T7, TAccessor7>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T8 value) =>
        new(UnionMarshaller.ToJS<T8, TAccessor8>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T9 value) =>
        new(UnionMarshaller.ToJS<T9, TAccessor9>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T10 value) =>
        new(UnionMarshaller.ToJS<T10, TAccessor10>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T11 value) =>
        new(UnionMarshaller.ToJS<T11, TAccessor11>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T12 value) =>
        new(UnionMarshaller.ToJS<T12, TAccessor12>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T13 value) =>
        new(UnionMarshaller.ToJS<T13, TAccessor13>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T14 value) =>
        new(UnionMarshaller.ToJS<T14, TAccessor14>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T15 value) =>
        new(UnionMarshaller.ToJS<T15, TAccessor15>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T16 value) =>
        new(UnionMarshaller.ToJS<T16, TAccessor16>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T17 value) =>
        new(UnionMarshaller.ToJS<T17, TAccessor17>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T18 value) =>
        new(UnionMarshaller.ToJS<T18, TAccessor18>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T19 value) =>
        new(UnionMarshaller.ToJS<T19, TAccessor19>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T20 value) =>
        new(UnionMarshaller.ToJS<T20, TAccessor20>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T21 value) =>
        new(UnionMarshaller.ToJS<T21, TAccessor21>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T22 value) =>
        new(UnionMarshaller.ToJS<T22, TAccessor22>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T23 value) =>
        new(UnionMarshaller.ToJS<T23, TAccessor23>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T24 value) =>
        new(UnionMarshaller.ToJS<T24, TAccessor24>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T25 value) =>
        new(UnionMarshaller.ToJS<T25, TAccessor25>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T26 value) =>
        new(UnionMarshaller.ToJS<T26, TAccessor26>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T27 value) =>
        new(UnionMarshaller.ToJS<T27, TAccessor27>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T28 value) =>
        new(UnionMarshaller.ToJS<T28, TAccessor28>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T29 value) =>
        new(UnionMarshaller.ToJS<T29, TAccessor29>(value));

    [SupportedOSPlatform("browser")]
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TAccessor1, TAccessor2, TAccessor3, TAccessor4, TAccessor5, TAccessor6, TAccessor7, TAccessor8, TAccessor9, TAccessor10, TAccessor11, TAccessor12, TAccessor13, TAccessor14, TAccessor15, TAccessor16, TAccessor17, TAccessor18, TAccessor19, TAccessor20, TAccessor21, TAccessor22, TAccessor23, TAccessor24, TAccessor25, TAccessor26, TAccessor27, TAccessor28, TAccessor29, TAccessor30>(T30 value) =>
        new(UnionMarshaller.ToJS<T30, TAccessor30>(value));

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T1? value) =>
        UnionMarshaller.TryToManaged<T1, TAccessor1>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T2? value) =>
        UnionMarshaller.TryToManaged<T2, TAccessor2>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T3? value) =>
        UnionMarshaller.TryToManaged<T3, TAccessor3>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T4? value) =>
        UnionMarshaller.TryToManaged<T4, TAccessor4>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T5? value) =>
        UnionMarshaller.TryToManaged<T5, TAccessor5>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T6? value) =>
        UnionMarshaller.TryToManaged<T6, TAccessor6>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T7? value) =>
        UnionMarshaller.TryToManaged<T7, TAccessor7>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T8? value) =>
        UnionMarshaller.TryToManaged<T8, TAccessor8>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T9? value) =>
        UnionMarshaller.TryToManaged<T9, TAccessor9>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T10? value) =>
        UnionMarshaller.TryToManaged<T10, TAccessor10>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T11? value) =>
        UnionMarshaller.TryToManaged<T11, TAccessor11>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T12? value) =>
        UnionMarshaller.TryToManaged<T12, TAccessor12>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T13? value) =>
        UnionMarshaller.TryToManaged<T13, TAccessor13>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T14? value) =>
        UnionMarshaller.TryToManaged<T14, TAccessor14>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T15? value) =>
        UnionMarshaller.TryToManaged<T15, TAccessor15>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T16? value) =>
        UnionMarshaller.TryToManaged<T16, TAccessor16>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T17? value) =>
        UnionMarshaller.TryToManaged<T17, TAccessor17>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T18? value) =>
        UnionMarshaller.TryToManaged<T18, TAccessor18>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T19? value) =>
        UnionMarshaller.TryToManaged<T19, TAccessor19>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T20? value) =>
        UnionMarshaller.TryToManaged<T20, TAccessor20>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T21? value) =>
        UnionMarshaller.TryToManaged<T21, TAccessor21>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T22? value) =>
        UnionMarshaller.TryToManaged<T22, TAccessor22>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T23? value) =>
        UnionMarshaller.TryToManaged<T23, TAccessor23>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T24? value) =>
        UnionMarshaller.TryToManaged<T24, TAccessor24>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T25? value) =>
        UnionMarshaller.TryToManaged<T25, TAccessor25>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T26? value) =>
        UnionMarshaller.TryToManaged<T26, TAccessor26>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T27? value) =>
        UnionMarshaller.TryToManaged<T27, TAccessor27>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T28? value) =>
        UnionMarshaller.TryToManaged<T28, TAccessor28>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T29? value) =>
        UnionMarshaller.TryToManaged<T29, TAccessor29>(JSObject, out value);

    [SupportedOSPlatform("browser")]
    public bool TryCast([NotNullWhen(true)] out T30? value) =>
        UnionMarshaller.TryToManaged<T30, TAccessor30>(JSObject, out value);
}
