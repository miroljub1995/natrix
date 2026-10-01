// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class XRProjectionLayerInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<XRProjectionLayerInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRProjectionLayerInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static XRProjectionLayerInit global::Natrix.JSCore.IJSObjectProxy<XRProjectionLayerInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public XRProjectionLayerInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.XRTextureType TextureType
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRTextureType>.Get(JSObject, "textureType");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.XRTextureType>.Set(JSObject, "textureType", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ColorFormat
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "colorFormat");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "colorFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DepthFormat
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "depthFormat");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "depthFormat", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScaleFactor
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scaleFactor");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "scaleFactor", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ClearOnAccess
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "clearOnAccess");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "clearOnAccess", value);
    }
}

#nullable disable