using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class JSObjectAccessor : IUnionMemberAccessor<JSObject>
{
    public static bool CanRead(JSValueKind kind) => kind is JSValueKind.Object or JSValueKind.Function;

    [SupportedOSPlatform("browser")]
    public static JSObject Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsJSObjectV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static JSObject Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsJSObjectV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, JSObject value) =>
        obj.SetPropertyAsJSObjectV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, JSObject value) =>
        obj.SetPropertyAsJSObjectV2(propertyIndex, value);
}
