using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableUInt64Accessor : IPropertyAccessor<ulong?>
{
    [SupportedOSPlatform("browser")]
    public static ulong? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToUInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static ulong? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToUInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, ulong? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, ulong? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}
