// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRTransientInputHitTestOptionsInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestOptionsInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRTransientInputHitTestOptionsInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRTransientInputHitTestOptionsInit global::Natrix.JSCore.IJSObjectProxy<XRTransientInputHitTestOptionsInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRTransientInputHitTestOptionsInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Profile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "profile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "profile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRHitTestTrackableType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHitTestTrackableType>> EntityTypes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRHitTestTrackableType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHitTestTrackableType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRHitTestTrackableType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHitTestTrackableType>>>>(JSObject, "entityTypes");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRHitTestTrackableType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHitTestTrackableType>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRHitTestTrackableType, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRHitTestTrackableType>>>>(JSObject, "entityTypes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRRay OffsetRay
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.XRRay, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRay>>(JSObject, "offsetRay");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.XRRay, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRRay>>(JSObject, "offsetRay", value);
    }
}

#nullable disable