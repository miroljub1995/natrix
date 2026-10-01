using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class ByteAccessor : IUnionMemberAccessor<byte>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static byte Get(JSObject obj, string propertyName) =>
        Convert.ToByte(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static byte Get(JSObject obj, int propertyIndex) =>
        Convert.ToByte(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, byte value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, byte value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}
