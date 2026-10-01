// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRWebGLLayerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRWebGLLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRWebGLLayerInit global::Natrix.JSCore.IJSObjectProxy<XRWebGLLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRWebGLLayerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Antialias
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "antialias");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "antialias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Depth
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "depth");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "depth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Stencil
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "stencil");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "stencil", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IgnoreDepthValues
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ignoreDepthValues");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ignoreDepthValues", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double FramebufferScaleFactor
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "framebufferScaleFactor");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "framebufferScaleFactor", value);
    }
}

#nullable disable