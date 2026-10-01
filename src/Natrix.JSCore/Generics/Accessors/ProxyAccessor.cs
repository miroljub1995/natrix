using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class ProxyAccessor<T> : IUnionMemberAccessor<T>
    where T : JSObjectProxy, IJSObjectProxy<T>
{
    // Callbacks and callback interfaces can be functions, so both kinds are accepted.
    public static bool CanRead(JSValueKind kind) => kind is JSValueKind.Object or JSValueKind.Function;

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, string propertyName) =>
        T.Create(obj.GetPropertyAsJSObjectV2(propertyName));

    [SupportedOSPlatform("browser")]
    public static T Get(JSObject obj, int propertyIndex) =>
        T.Create(obj.GetPropertyAsJSObjectV2(propertyIndex));

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, T value) =>
        obj.SetPropertyAsJSObjectV2(propertyName, value.JSObject);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, T value) =>
        obj.SetPropertyAsJSObjectV2(propertyIndex, value.JSObject);
}
