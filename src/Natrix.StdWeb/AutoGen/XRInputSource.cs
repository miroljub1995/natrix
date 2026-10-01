// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRInputSource: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRInputSource>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSource(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRInputSource global::Natrix.JSCore.IJSObjectProxy<XRInputSource>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<XRInputSource>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Gamepad? Gamepad
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Gamepad>.Get(JSObject, "gamepad");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHand? Hand
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRHand>.Get(JSObject, "hand");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHandedness Handedness
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHandedness>.Get(JSObject, "handedness");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRTargetRayMode TargetRayMode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRTargetRayMode>.Get(JSObject, "targetRayMode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace TargetRaySpace
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "targetRaySpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace? GripSpace
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "gripSpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> Profiles
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "profiles");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SkipRendering
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "skipRendering");
    }
}

#nullable disable