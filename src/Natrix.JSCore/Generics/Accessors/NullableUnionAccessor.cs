using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableUnionAccessor<T> : IPropertyAccessor<T?>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsUnionV2AsNullable(propertyName) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static T? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsUnionV2AsNullable(propertyIndex) is { } res ? T.Create(res) : null;

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T? value) =>
        obj.SetPropertyAsUnionAsNullable(propertyName, value?.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T? value) =>
        obj.SetPropertyAsUnionAsNullable(propertyIndex, value?.JSObject);
}
