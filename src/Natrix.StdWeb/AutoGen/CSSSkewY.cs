// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSSkewY: global::Natrix.StdWeb.CSSTransformComponent, global::Natrix.JSCore.IJSObjectProxy<CSSSkewY>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSSkewY(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSSkewY global::Natrix.JSCore.IJSObjectProxy<CSSSkewY>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSSkewY>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSSkewY New(global::Natrix.StdWeb.CSSNumericValue ay)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = ay.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSSkewY", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSSkewY(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericValue Ay
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>.Get(JSObject, "ay");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSNumericValue>.Set(JSObject, "ay", value);
    }
}

#nullable disable