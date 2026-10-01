// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Ink: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Ink>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Ink(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Ink global::Natrix.JSCore.IJSObjectProxy<Ink>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Ink>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>> RequestPresenter()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "requestPresenter", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>> RequestPresenter(global::Natrix.StdWeb.InkPresenterParam param)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = param.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "requestPresenter", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.StdWeb.DelegatedInkTrailPresenter, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DelegatedInkTrailPresenter>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable