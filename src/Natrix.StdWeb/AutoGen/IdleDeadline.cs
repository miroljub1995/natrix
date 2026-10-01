// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IdleDeadline: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IdleDeadline>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IdleDeadline(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IdleDeadline global::Natrix.JSCore.IJSObjectProxy<IdleDeadline>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IdleDeadline>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TimeRemaining()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "timeRemaining", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.DoubleAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DidTimeout
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "didTimeout");
    }
}

#nullable disable