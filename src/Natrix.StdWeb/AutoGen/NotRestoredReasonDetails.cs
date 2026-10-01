// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NotRestoredReasonDetails: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NotRestoredReasonDetails>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotRestoredReasonDetails(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NotRestoredReasonDetails global::Natrix.JSCore.IJSObjectProxy<NotRestoredReasonDetails>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<NotRestoredReasonDetails>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Reason
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "reason");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable