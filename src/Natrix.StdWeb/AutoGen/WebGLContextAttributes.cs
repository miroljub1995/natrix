// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebGLContextAttributes: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<WebGLContextAttributes>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebGLContextAttributes(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static WebGLContextAttributes global::Natrix.JSCore.IJSObjectProxy<WebGLContextAttributes>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebGLContextAttributes(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Alpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alpha", value);
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
    public bool Antialias
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "antialias");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "antialias", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PremultipliedAlpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "premultipliedAlpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "premultipliedAlpha", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreserveDrawingBuffer
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preserveDrawingBuffer");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preserveDrawingBuffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebGLPowerPreference PowerPreference
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebGLPowerPreference>.Get(JSObject, "powerPreference");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.WebGLPowerPreference>.Set(JSObject, "powerPreference", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FailIfMajorPerformanceCaveat
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "failIfMajorPerformanceCaveat");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "failIfMajorPerformanceCaveat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Desynchronized
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "desynchronized");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "desynchronized", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool XrCompatible
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "xrCompatible");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "xrCompatible", value);
    }
}

#nullable disable