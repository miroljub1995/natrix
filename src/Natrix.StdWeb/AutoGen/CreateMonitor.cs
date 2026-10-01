// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CreateMonitor: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<CreateMonitor>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CreateMonitor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CreateMonitor global::Natrix.JSCore.IJSObjectProxy<CreateMonitor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CreateMonitor>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Ondownloadprogress
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "ondownloadprogress");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "ondownloadprogress", value);
    }
}

#nullable disable