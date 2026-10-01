using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class SingleAccessor : IUnionMemberAccessor<float>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static float Get(JSObject obj, string propertyName) =>
        Convert.ToSingle(obj.GetPropertyAsDoubleV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static float Get(JSObject obj, int propertyIndex) =>
        Convert.ToSingle(obj.GetPropertyAsDoubleV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, float value) =>
        obj.SetPropertyAsDoubleV2(propertyName, Convert.ToDouble(value));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, float value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, Convert.ToDouble(value));
}
