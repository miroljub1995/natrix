// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PermissionStatus: global::Natrix.StdWeb.EventTarget, global::Natrix.JSCore.IJSObjectProxy<PermissionStatus>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PermissionStatus(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PermissionStatus global::Natrix.JSCore.IJSObjectProxy<PermissionStatus>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PermissionStatus>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PermissionState State
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>.Get(JSObject, "state");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onchange", value);
    }
}

#nullable disable