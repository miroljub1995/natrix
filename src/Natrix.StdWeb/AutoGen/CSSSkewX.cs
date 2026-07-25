// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSSkewX: global::Natrix.StdWeb.CSSTransformComponent
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSSkewX(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSSkewX New(global::Natrix.StdWeb.CSSNumericValue ax)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = ax.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSSkewX", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSSkewX(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericValue Ax
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ax");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ax", value);
    }
}

#nullable disable