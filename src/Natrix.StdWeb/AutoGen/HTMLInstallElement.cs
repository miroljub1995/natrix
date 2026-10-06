// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLInstallElement: global::Natrix.StdWeb.HTMLElement, global::Natrix.JSCore.IJSObjectProxy<HTMLInstallElement>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLInstallElement(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLInstallElement global::Natrix.JSCore.IJSObjectProxy<HTMLInstallElement>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLInstallElement>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.HTMLInstallElement New()
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "HTMLInstallElement");
        return new global::Natrix.StdWeb.HTMLInstallElement(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Manifest
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "manifest");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "manifest", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? ManifestId
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "manifestId");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "manifestId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Oninstallresult
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "oninstallresult");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "oninstallresult", value);
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
}

#nullable disable