// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCopyExternalImageDestInfo: global::Natrix.StdWeb.GPUTexelCopyTextureInfo, global::Natrix.JSCore.IJSObjectProxy<GPUCopyExternalImageDestInfo>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCopyExternalImageDestInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUCopyExternalImageDestInfo global::Natrix.JSCore.IJSObjectProxy<GPUCopyExternalImageDestInfo>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCopyExternalImageDestInfo(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.PredefinedColorSpace ColorSpace
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.PredefinedColorSpace>.Set(JSObject, "colorSpace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PremultipliedAlpha
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "premultipliedAlpha");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "premultipliedAlpha", value);
    }
}

#nullable disable