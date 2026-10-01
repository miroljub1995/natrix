using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableJSObjectAccessor : IPropertyAccessor<JSObject?>
{
    [SupportedOSPlatform("browser")]
    public static JSObject? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static JSObject? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsJSObjectV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, JSObject? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, JSObject? value) =>
        obj.SetPropertyAsJSObjectV2AsNullable(propertyIndex, value);
}
