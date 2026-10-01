// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRSessionEvent: global::Natrix.StdWeb.Event, global::Natrix.JSCore.IJSObjectProxy<XRSessionEvent>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRSessionEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRSessionEvent global::Natrix.JSCore.IJSObjectProxy<XRSessionEvent>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRSessionEvent>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.XRSessionEvent New(string type, global::Natrix.StdWeb.XRSessionEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "XRSessionEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.XRSessionEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSession Session
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSession>.Get(JSObject, "session");
    }
}

#nullable disable