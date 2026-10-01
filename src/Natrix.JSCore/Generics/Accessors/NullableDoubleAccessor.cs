using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableDoubleAccessor : IPropertyAccessor<double?>
{
    [SupportedOSPlatform("browser")]
    public static double? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static double? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, double? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, double? value) =>
        obj.SetPropertyAsDoubleV2AsNullable(propertyIndex, value);
}
