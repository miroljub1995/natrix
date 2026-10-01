using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class SByteAccessor : IUnionMemberAccessor<sbyte>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static sbyte Get(JSObject obj, string propertyName) =>
        Convert.ToSByte(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static sbyte Get(JSObject obj, int propertyIndex) =>
        Convert.ToSByte(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, sbyte value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, sbyte value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}
