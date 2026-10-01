// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingSegment: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingSegment>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingSegment(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingSegment global::Natrix.JSCore.IJSObjectProxy<HandwritingSegment>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingSegment(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Grapheme
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "grapheme");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "grapheme", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint BeginIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "beginIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "beginIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint EndIndex
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "endIndex");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "endIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingDrawingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingDrawingSegment>> DrawingSegments
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingDrawingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingDrawingSegment>>>.Get(JSObject, "drawingSegments");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.HandwritingDrawingSegment, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HandwritingDrawingSegment>>>.Set(JSObject, "drawingSegments", value);
    }
}

#nullable disable