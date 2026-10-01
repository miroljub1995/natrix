// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGRect: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGRect>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGRect(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGRect global::Natrix.JSCore.IJSObjectProxy<SVGRect>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGRect>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float X
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Y
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Width
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Height
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "height", value);
    }
}

#nullable disable