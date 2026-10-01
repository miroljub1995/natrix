// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoDecoderConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<VideoDecoderConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoDecoderConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static VideoDecoderConfig global::Natrix.JSCore.IJSObjectProxy<VideoDecoderConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoDecoderConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Codec
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "codec");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "codec", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.SharedArrayBuffer, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.SharedArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>> Description
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.SharedArrayBuffer, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.SharedArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>>>.Get(JSObject, "description");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.ArrayBuffer, global::Natrix.JSCore.SharedArrayBuffer, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.ArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.SharedArrayBuffer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Int32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Uint8ClampedArray>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigInt64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.BigUint64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float16Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float32Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Float64Array>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.DataView>>>.Set(JSObject, "description", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CodedWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "codedWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "codedWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CodedHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "codedHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "codedHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DisplayAspectWidth
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayAspectWidth");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayAspectWidth", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint DisplayAspectHeight
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "displayAspectHeight");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "displayAspectHeight", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.VideoColorSpaceInit ColorSpace
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoColorSpaceInit>.Get(JSObject, "colorSpace");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.VideoColorSpaceInit>.Set(JSObject, "colorSpace", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HardwareAcceleration HardwareAcceleration
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HardwareAcceleration>.Get(JSObject, "hardwareAcceleration");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HardwareAcceleration>.Set(JSObject, "hardwareAcceleration", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool OptimizeForLatency
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "optimizeForLatency");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "optimizeForLatency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Rotation
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "rotation");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "rotation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Flip
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "flip");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "flip", value);
    }
}

#nullable disable