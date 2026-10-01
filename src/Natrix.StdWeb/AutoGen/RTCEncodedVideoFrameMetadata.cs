// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCEncodedVideoFrameMetadata: global::Natrix.StdWeb.RTCEncodedFrameMetadata, global::Natrix.JSCore.IJSObjectProxy<RTCEncodedVideoFrameMetadata>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedVideoFrameMetadata(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCEncodedVideoFrameMetadata global::Natrix.JSCore.IJSObjectProxy<RTCEncodedVideoFrameMetadata>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCEncodedVideoFrameMetadata(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong FrameId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "frameId");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "frameId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<ulong, global::Natrix.JSCore.Generics.UInt64Accessor> Dependencies
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>>.Get(JSObject, "dependencies");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<ulong, global::Natrix.JSCore.Generics.UInt64Accessor>>.Set(JSObject, "dependencies", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Width
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "width");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "width", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Height
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "height");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "height", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint SpatialIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "spatialIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "spatialIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint TemporalIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "temporalIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "temporalIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long Timestamp
    {
        get => global::Natrix.JSCore.Generics.Int64Accessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.Int64Accessor.Set(JSObject, "timestamp", value);
    }
}

#nullable disable