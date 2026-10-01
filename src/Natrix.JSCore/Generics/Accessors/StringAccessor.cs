using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class StringAccessor : IUnionMemberAccessor<string>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.String;

    [SupportedOSPlatform("browser")]
    public static string Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsStringV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static string Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsStringV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, string value) =>
        obj.SetPropertyAsStringV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, string value) =>
        obj.SetPropertyAsStringV2(propertyIndex, value);
}
