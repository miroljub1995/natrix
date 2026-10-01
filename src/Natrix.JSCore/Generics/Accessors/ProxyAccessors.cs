using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class ProxyAccessor<T> : IUnionMemberAccessor<T>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    // Callbacks and callback interfaces can be functions, so both kinds are accepted.
    public static bool CanRead(JSValueKind kind) => kind is JSValueKind.Object or JSValueKind.Function;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsJSObjectV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsJSObjectV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsJSObjectV2(propertyName, value.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsJSObjectV2(propertyIndex, value.JSObject);
}

public sealed class NullableProxyAccessor<T> : IPropertyAccessor<T?>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyName) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyIndex) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyName, value?.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyIndex, value?.JSObject);
}

public sealed class UnionAccessor<T> : IUnionMemberAccessor<T>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    // A nested union is boxed again on read and checks its own members.
    public static bool CanRead(JSValueKind kind) => true;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsUnionV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsUnionV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsUnion(propertyName, value.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsUnion(propertyIndex, value.JSObject);
}

public sealed class NullableUnionAccessor<T> : IPropertyAccessor<T?>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsUnionV2AsNullable(propertyName) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsUnionV2AsNullable(propertyIndex) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T? value) =>
        obj.SetPropertyAsUnionAsNullable(propertyName, value?.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T? value) =>
        obj.SetPropertyAsUnionAsNullable(propertyIndex, value?.JSObject);
}

public sealed class EnumAccessor<T> : IUnionMemberAccessor<T>
    where T : class, IJSEnum<T>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.String;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsStringV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsStringV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsStringV2(propertyName, value.ToString()!);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsStringV2(propertyIndex, value.ToString()!);
}

public sealed class NullableEnumAccessor<T> : IPropertyAccessor<T?>
    where T : class, IJSEnum<T>
{
    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsStringV2AsNullable(propertyName) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsStringV2AsNullable(propertyIndex) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyName, value?.ToString());

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyIndex, value?.ToString());
}
