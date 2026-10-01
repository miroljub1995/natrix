using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableStringAccessor : IPropertyAccessor<string?>
{
    [SupportedOSPlatform("browser")]
    public static string? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsStringV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static string? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsStringV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, string? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, string? value) =>
        obj.SetPropertyAsStringV2AsNullable(propertyIndex, value);
}
