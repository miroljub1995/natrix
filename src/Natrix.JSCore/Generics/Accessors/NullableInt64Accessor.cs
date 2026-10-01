using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableInt64Accessor : IPropertyAccessor<long?>
{
    [SupportedOSPlatform("browser")]
    public static long? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName) is { } res ? Convert.ToInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static long? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex) is { } res ? Convert.ToInt64(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, long? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value is { } notNull ? Convert.ToDouble(notNull) : null);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, long? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value is { } notNull ? Convert.ToDouble(notNull) : null);
}
