using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableInt16Accessor : IPropertyAccessor<short?>
{
    [SupportedOSPlatform("browser")]
    public static short? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static short? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToInt16(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, short? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, short? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}
