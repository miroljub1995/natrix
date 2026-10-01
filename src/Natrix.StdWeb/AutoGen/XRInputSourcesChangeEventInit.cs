// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRInputSourcesChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<XRInputSourcesChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSourcesChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRInputSourcesChangeEventInit global::Natrix.JSCore.IJSObjectProxy<XRInputSourcesChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRInputSourcesChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRSession Session
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSession>.Get(JSObject, "session");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSession>.Set(JSObject, "session", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>> Added
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>>.Get(JSObject, "added");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>>.Set(JSObject, "added", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>> Removed
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>>.Get(JSObject, "removed");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRInputSource, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRInputSource>>>.Set(JSObject, "removed", value);
    }
}

#nullable disable