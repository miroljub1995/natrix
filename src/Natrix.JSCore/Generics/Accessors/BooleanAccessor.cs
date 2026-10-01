using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class BooleanAccessor : IUnionMemberAccessor<bool>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Boolean;

    [SupportedOSPlatform("browser")]
    public static bool Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBooleanV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static bool Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBooleanV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, bool value) =>
        obj.SetPropertyAsBooleanV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, bool value) =>
        obj.SetPropertyAsBooleanV2(propertyIndex, value);
}
