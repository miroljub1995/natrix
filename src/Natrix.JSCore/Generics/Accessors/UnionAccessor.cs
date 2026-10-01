using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class UnionAccessor<T> : IUnionMemberAccessor<T>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    // A nested union is boxed again on read and checks its own members.
    public static bool CanRead(JSValueKind kind) => true;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsUnionV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsUnionV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsUnion(propertyName, value.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsUnion(propertyIndex, value.JSObject);
}
