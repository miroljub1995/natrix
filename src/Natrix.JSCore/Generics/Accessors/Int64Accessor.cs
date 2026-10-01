using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class Int64Accessor : IUnionMemberAccessor<long>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static long Get(JSObject obj, string propertyName) =>
        Convert.ToInt64(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static long Get(JSObject obj, int propertyIndex) =>
        Convert.ToInt64(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, long value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, long value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}
