// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRVisibilityMaskChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<XRVisibilityMaskChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRVisibilityMaskChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRVisibilityMaskChangeEventInit global::Natrix.JSCore.IJSObjectProxy<XRVisibilityMaskChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRVisibilityMaskChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRSession Session
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSession>.Get(JSObject, "session");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSession>.Set(JSObject, "session", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XREye Eye
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XREye>.Get(JSObject, "eye");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XREye>.Set(JSObject, "eye", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint Index
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "index");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "index", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Float32Array Vertices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>.Get(JSObject, "vertices");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>.Set(JSObject, "vertices", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Uint32Array Indices
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>.Get(JSObject, "indices");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>.Set(JSObject, "indices", value);
    }
}

#nullable disable