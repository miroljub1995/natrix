using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

/// <summary>
/// Moves a single union member in and out of the <c>{ type, value }</c> box that unions are
/// represented with, using the member's own accessor.
/// </summary>
[SupportedOSPlatform("browser")]
public static partial class UnionMarshaller
{
    [JSImport("construct", "natrix")]
    private static partial JSObject ConstructObject(JSObject obj, string constructorName);

    public static JSObject ToJS<T, TAccessor>(T value)
        where TAccessor : IUnionMemberAccessor<T>
    {
        var box = ConstructObject(JSHost.GlobalThis, "Object");
        TAccessor.Set(box, "value", value);
        return box;
    }

    public static bool TryToManaged<T, TAccessor>(JSObject box, [MaybeNullWhen(false)] out T value)
        where TAccessor : IUnionMemberAccessor<T>
    {
        var kind = (JSValueKind)Convert.ToInt32(box.GetPropertyAsDoubleV2("type"));
        if (!TAccessor.CanRead(kind))
        {
            value = default;
            return false;
        }

        try
        {
            value = TAccessor.Get(box, "value");
            return true;
        }
        catch
        {
            value = default;
            return false;
        }
    }
}
