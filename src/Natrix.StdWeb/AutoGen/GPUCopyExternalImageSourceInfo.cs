// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCopyExternalImageSourceInfo: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCopyExternalImageSourceInfo(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCopyExternalImageSourceInfo(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ImageBitmap, global::Natrix.StdWeb.ImageData, global::Natrix.StdWeb.HTMLImageElement, global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.StdWeb.GenericMarshaller.Union> Source
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ImageBitmap, global::Natrix.StdWeb.ImageData, global::Natrix.StdWeb.HTMLImageElement, global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "source");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ImageBitmap, global::Natrix.StdWeb.ImageData, global::Natrix.StdWeb.HTMLImageElement, global::Natrix.StdWeb.HTMLVideoElement, global::Natrix.StdWeb.VideoFrame, global::Natrix.StdWeb.HTMLCanvasElement, global::Natrix.StdWeb.OffscreenCanvas, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin2DDict, global::Natrix.StdWeb.GenericMarshaller.Union> Origin
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin2DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GPUOrigin2DDict, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FlipY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "flipY");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "flipY", value);
    }
}

#nullable disable