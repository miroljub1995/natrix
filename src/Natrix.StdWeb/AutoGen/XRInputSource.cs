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
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Gamepad?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Gamepad>>(JSObject, "gamepad");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHand? Hand
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRHand?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRHand>>(JSObject, "hand");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRHandedness Handedness
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRHandedness, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHandedness>>(JSObject, "handedness");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRTargetRayMode TargetRayMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRTargetRayMode, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRTargetRayMode>>(JSObject, "targetRayMode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace TargetRaySpace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRSpace, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>>(JSObject, "targetRaySpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRSpace? GripSpace
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRSpace?, global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.XRSpace>>(JSObject, "gripSpace");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> Profiles
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "profiles");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SkipRendering
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "skipRendering");
    }
}

#nullable disable