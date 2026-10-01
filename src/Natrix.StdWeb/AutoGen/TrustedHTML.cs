// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TrustedHTML: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TrustedHTML>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TrustedHTML(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TrustedHTML global::Natrix.JSCore.IJSObjectProxy<TrustedHTML>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TrustedHTML>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void _()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "", JSObject, ___resOwner_1.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.StringAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable