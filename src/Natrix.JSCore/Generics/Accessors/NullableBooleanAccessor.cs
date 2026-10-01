using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableBooleanAccessor : IPropertyAccessor<bool?>
{
    [SupportedOSPlatform("browser")]
    public static bool? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBooleanV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static bool? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBooleanV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, bool? value) =>
        obj.SetPropertyAsBooleanV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, bool? value) =>
        obj.SetPropertyAsBooleanV2AsNullable(propertyIndex, value);
}
