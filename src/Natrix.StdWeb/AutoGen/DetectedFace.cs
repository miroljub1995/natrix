// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DetectedFace: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DetectedFace>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DetectedFace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DetectedFace global::Natrix.JSCore.IJSObjectProxy<DetectedFace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DetectedFace(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.DOMRectReadOnly BoundingBox
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Get(JSObject, "boundingBox");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectReadOnly>.Set(JSObject, "boundingBox", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Landmark>>? Landmarks
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Landmark>>>.Get(JSObject, "landmarks");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Landmark>>>.Set(JSObject, "landmarks", value);
    }
}

#nullable disable