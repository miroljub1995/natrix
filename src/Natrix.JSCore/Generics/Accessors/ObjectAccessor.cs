using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class ObjectAccessor : IUnionMemberAccessor<object>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.ManagedObject;

    [SupportedOSPlatform("browser")]
    public static object Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsObjectV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static object Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsObjectV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, object value) =>
        obj.SetPropertyAsObjectV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, object value) =>
        obj.SetPropertyAsObjectV2(propertyIndex, value);
}
