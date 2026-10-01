using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class DoubleAccessor : IUnionMemberAccessor<double>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.Number;

    [SupportedOSPlatform("browser")]
    public static double Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsDoubleV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static double Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsDoubleV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, double value) =>
        obj.SetPropertyAsDoubleV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, double value) =>
        obj.SetPropertyAsDoubleV2(propertyIndex, value);
}
