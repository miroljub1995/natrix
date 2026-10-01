// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLGeolocationElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLGeolocationElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLGeolocationElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLGeolocationElement global::Natrix.JSCore.IJSObjectProxy<HTMLGeolocationElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLGeolocationElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLGeolocationElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLGeolocationElement");
        return new global::Natrix.StdWeb.HTMLGeolocationElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GeolocationPosition? Position
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GeolocationPosition>.Get(JSObject, "position");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GeolocationPositionError? Error
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.GeolocationPositionError>.Get(JSObject, "error");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Autolocate
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "autolocate");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "autolocate", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Watch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "watch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "watch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onlocation
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onlocation");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onlocation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsValid
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isValid");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ActivationBlockersMixinBlockerReason InvalidReason
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ActivationBlockersMixinBlockerReason>.Get(JSObject, "invalidReason");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onvalidationstatuschange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onvalidationstatuschange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onvalidationstatuschange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PermissionState InitialPermissionStatus
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>.Get(JSObject, "initialPermissionStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PermissionState PermissionStatus
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PermissionState>.Get(JSObject, "permissionStatus");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onpromptaction
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onpromptaction");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onpromptaction", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onpromptdismiss
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onpromptdismiss");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onpromptdismiss", value);
    }
}

#nullable disable