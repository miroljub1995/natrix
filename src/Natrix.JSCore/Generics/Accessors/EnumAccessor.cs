using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class EnumAccessor<T> : IUnionMemberAccessor<T>
    where T : class, IJSEnum<T>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.String;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsStringV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsStringV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsStringV2(propertyName, value.ToString()!);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsStringV2(propertyIndex, value.ToString()!);
}
