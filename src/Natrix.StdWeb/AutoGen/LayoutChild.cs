// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LayoutChild: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LayoutChild>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LayoutChild(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LayoutChild global::Natrix.JSCore.IJSObjectProxy<LayoutChild>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<LayoutChild>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.StylePropertyMapReadOnly StyleMap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.StylePropertyMapReadOnly, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StylePropertyMapReadOnly>>(JSObject, "styleMap");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.IntrinsicSizes, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IntrinsicSizes>> IntrinsicSizes()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "intrinsicSizes", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.IntrinsicSizes, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IntrinsicSizes>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.IntrinsicSizes, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.IntrinsicSizes>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>> LayoutNextFragment(global::Natrix.StdWeb.LayoutConstraintsOptions constraints, global::Natrix.StdWeb.ChildBreakToken breakToken)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = constraints.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = breakToken.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "layoutNextFragment", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.LayoutFragment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.LayoutFragment>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable