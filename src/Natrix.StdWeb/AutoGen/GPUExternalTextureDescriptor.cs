// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUExternalTextureDescriptor: global::Natrix.StdWeb.GPUObjectDescriptorBase, global::Natrix.JSCore.IJSObjectProxy<GPUExternalTextureDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUExternalTextureDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUExternalTextureDescriptor global::Natrix.JSCore.IJSObjectProxy<GPUExternalTextureDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUExternalTextureDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLVideoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>> Source
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLVideoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>>>.Get(JSObject, "source");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLVideoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoFrame>>>.Set(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PredefinedColorSpace ColorSpace
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Set(JSObject, "colorSpace", value);
    }
}

#nullable disable