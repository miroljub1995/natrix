// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRMediaLayerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRMediaLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRMediaLayerInit global::Natrix.JSCore.IJSObjectProxy<XRMediaLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRMediaLayerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.XRSpace Space
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Get(JSObject, "space");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.XRSpace>.Set(JSObject, "space", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRLayerLayout Layout
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerLayout>.Get(JSObject, "layout");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRLayerLayout>.Set(JSObject, "layout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool InvertStereo
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "invertStereo");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "invertStereo", value);
    }
}

#nullable disable