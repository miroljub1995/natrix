using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableObjectAccessor : IPropertyAccessor<object?>
{
    [SupportedOSPlatform("browser")]
    public static object? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsObjectV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static object? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsObjectV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, object? value) =>
        obj.SetPropertyAsObjectV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, object? value) =>
        obj.SetPropertyAsObjectV2AsNullable(propertyIndex, value);
}
