// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGNumber: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGNumber>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGNumber(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGNumber global::Natrix.JSCore.IJSObjectProxy<SVGNumber>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGNumber>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Value
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "value", value);
    }
}

#nullable disable