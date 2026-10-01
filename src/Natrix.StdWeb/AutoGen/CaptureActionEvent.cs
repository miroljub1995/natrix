// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CaptureActionEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<CaptureActionEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CaptureActionEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CaptureActionEvent global::Natrix.JSCore.IJSObjectProxy<CaptureActionEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CaptureActionEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CaptureActionEvent New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CaptureActionEvent");
        return new global::Natrix.StdWeb.CaptureActionEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CaptureActionEvent New(global::Natrix.StdWeb.CaptureActionEventInit init)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CaptureActionEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CaptureActionEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CaptureAction Action
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CaptureAction, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CaptureAction>>(JSObject, "action");
    }
}

#nullable disable