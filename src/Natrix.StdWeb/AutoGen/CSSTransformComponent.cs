// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSTransformComponent: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSTransformComponent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSTransformComponent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSTransformComponent global::Natrix.JSCore.IJSObjectProxy<CSSTransformComponent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSTransformComponent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void _()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "", JSObject, ___resOwner_1.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Is2D
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "is2D");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "is2D", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMMatrix ToMatrix()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toMatrix", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMMatrix>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable