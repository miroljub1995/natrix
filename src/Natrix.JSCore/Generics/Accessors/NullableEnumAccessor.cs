using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

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
