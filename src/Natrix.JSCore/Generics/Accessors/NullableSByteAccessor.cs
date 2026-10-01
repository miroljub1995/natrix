using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableSByteAccessor : IPropertyAccessor<sbyte?>
{
    [SupportedOSPlatform("browser")]
    public static sbyte? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToSByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static sbyte? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToSByte(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, sbyte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, sbyte? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}
