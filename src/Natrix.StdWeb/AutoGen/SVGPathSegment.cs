// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGPathSegment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGPathSegment>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGPathSegment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGPathSegment global::Natrix.JSCore.IJSObjectProxy<SVGPathSegment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGPathSegment>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Type
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "type");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<float, global::Natrix.JSCore.Generics.SingleAccessor> Values
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<float, global::Natrix.JSCore.Generics.SingleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>>(JSObject, "values");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.FrozenArray<float, global::Natrix.JSCore.Generics.SingleAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<float, global::Natrix.JSCore.Generics.SingleAccessor>>>(JSObject, "values", value);
    }
}

#nullable disable